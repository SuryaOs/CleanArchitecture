using EGrocer.Application;
using EGrocer.Infrastructure;
using EGrocer.API;

var builder = WebApplication.CreateBuilder(args);

builder.Services
       .AddApplication()
       .AddInfrastructure()
       .AddPresentation()
       .AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
