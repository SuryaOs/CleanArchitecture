using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;

namespace EGrocer.API.Extensions;

public static class AuthenticationExtension
{
    public static IServiceCollection ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddMicrosoftIdentityWebApi(configuration);

        return services;
    }
    public static IApplicationBuilder AddAuthentication(this IApplicationBuilder app)
    {
        app.UseAuthentication();

        return app;
    }
}
