using EGrocer.Application;
using EGrocer.Infrastructure;
using EGrocer.API;
using EGrocer.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services
       .AddApplication()
       .AddInfrastructure(builder.Configuration)
       .AddPresentation()
       .AddControllers();

var app = builder.Build();

app.AddSwagger();
app.UseHttpsRedirection();
app.MapControllers();
app.Run();
