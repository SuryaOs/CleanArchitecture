using EGrocer.Application;
using EGrocer.Infrastructure;
using EGrocer.API;
using EGrocer.API.Extensions;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services
       .AddApplication()
       .AddInfrastructure(configuration)
       .AddPresentation(configuration)
       .AddControllers();


var app = builder.Build();

app.AddSwagger();
app.AddCors();
app.UseHttpsRedirection();
app.MapControllers();
app.Run();
