using Microsoft.Extensions.DependencyInjection;

namespace EGrocer.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}
