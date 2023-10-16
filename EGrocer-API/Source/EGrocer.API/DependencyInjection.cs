using EGrocer.API.Extensions;

namespace EGrocer.API;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .ConfigureOpenApi()
            .ConfigureCors()
            .ConfigureAuthentication(configuration);

        return services;
    }
}
