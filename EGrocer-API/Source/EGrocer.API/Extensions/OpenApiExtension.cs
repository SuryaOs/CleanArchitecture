using Microsoft.OpenApi.Models;

namespace EGrocer.API.Extensions;

public static class OpenApiExtension
{
    public static IServiceCollection ConfigureOpenApi(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "EGrocer Clean Architecture", Version = "v1" });
        });

        return services;
    }
    public static IApplicationBuilder AddSwagger(this IApplicationBuilder app)
    {
        app.UseSwagger();

        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        });

        return app;
    }
}
