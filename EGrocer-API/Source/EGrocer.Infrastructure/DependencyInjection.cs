using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using EGrocer.Infrastructure.Data;
using EGrocer.Core.Common.Interface;

namespace EGrocer.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("GrocerConnection_Local")))
            .AddScoped<IApplicationDbContext, ApplicationDbContext>();

        return services;
    }
}
