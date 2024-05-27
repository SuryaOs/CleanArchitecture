namespace EGrocer.API.Extensions;

public static class CorsExtension
{
    public static IServiceCollection ConfigureCors(this IServiceCollection services)
    {
        services.AddCors(p => p.AddPolicy("corsapp", builder =>
        {
            builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
        }));

        return services;
    }
    public static IApplicationBuilder AddCors(this IApplicationBuilder app)
    {
        app.UseCors("corsapp");

        return app;
    }
}
