using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using EGrocer.Infrastructure.Data;
using EGrocer.Core.Common.Interface;
using EGrocer.Core.Repositories.Command;
using EGrocer.Infrastructure.Repositories.Command;
using EGrocer.Core.Repositories.Queries;
using EGrocer.Infrastructure.Repositories.Queries;

namespace EGrocer.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("GrocerConnection_Local")))
            .AddScoped<IApplicationDbContext, ApplicationDbContext>()
            .AddQueries();

        return services;
    }
    private static IServiceCollection AddQueries(this IServiceCollection services)
    {
        return services.AddScoped<IProductQueryRepository, ProductQueryRepository>();
    }
}
