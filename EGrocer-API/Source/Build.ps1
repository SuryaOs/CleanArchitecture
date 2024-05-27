[CmdletBinding()]
param(
	[Parameter(Position=0,Mandatory=$false)][string]$versionSuffix = "0"
	)
Write-Host "==========================================="
Write-Host "Install tools"
Write-Host "==========================================="

& dotnet tool install -g swashbuckle.aspnetcore.cli --version 6.4.0

Write-Host "==========================================="
Write-Host "Clean"
Write-Host "==========================================="

& dotnet clean

Write-Host "==========================================="
Write-Host "Generate Swagger File"
Write-Host "==========================================="

New-Item -Path .\.build -Name swagger -ItemType Directory

& dotnet build .\EGrocer.API\EGrocer.API.csproj --configuration debug --version-suffix=$versionSuffix
if($? -ne $true) { throw "Debug Failed for generating Swagger file" }

Write-Host "==========================================="
Write-Host "Generate Swagger File - Build Step Completed"
Write-Host "==========================================="

& swagger tofile --output .\.build\swagger\swagger.json .\EGrocer.API\bin\Debug\net7.0\EGrocer.Api.dll v1
if($? -ne $true) { throw "Failed to generate Swagger file" }

Write-Host "==========================================="
Write-Host "Build client library to generate code "
Write-Host "==========================================="

& dotnet build .\EGrocer.API.Client\EGrocer.API.Client.csproj --configuration Release --version-suffix=$versionSuffix
if($? -ne $true) { throw "Client Library Build Failed" }

Write-Host "==========================================="
Write-Host "Build Solution"
Write-Host "==========================================="
Write-Host "Build Solution  path: $($PWD.Path)"
& dotnet build .\EGrocer.API\EGrocer.Api.sln --configuration Release --version-suffix=$versionSuffix
if($? -ne $true) { throw "Build Solution Failed" }

Write-Host "==========================================="
Write-Host "Publish"
Write-Host "==========================================="

Write-Host "Current directory path: $($PWD.Path)"

$publishProjects = @(
	"EGrocer.API"
	)

foreach ($projectName in $publishProjects) {
	$publishOutput = New-Item -Path .build\$projectName\ -ItemType Directory
	Write-Host "Current publish output path: $($publishOutput)"
	& dotnet publish $projectName\$projectName.csproj --configuration Release --no-build --no-restore --version-suffix=$versionSuffix --output $publishOutput
	if($? -ne $true) { throw "Publish Failed" }
}

Write-Host "==========================================="
Write-Host "Package client library"
Write-Host "==========================================="
$packageOutput = New-Item -Path .build\EGrocer.API.Client\ -ItemType Directory

& dotnet pack .\EGrocer.API.Client\EGrocer.API.Client.csproj /p:GenerateCode=False --configuration Release --no-build --no-restore --version-suffix=$versionSuffix --output $packageOutput

if($? -ne $true) { throw "Packagin Client Failed" }