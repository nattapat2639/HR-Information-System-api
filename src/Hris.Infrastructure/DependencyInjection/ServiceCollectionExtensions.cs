using Hris.Application.Interfaces.Repositories;
using Hris.Infrastructure.Persistence.Repositories;
using Hris.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hris.Infrastructure.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration,
        bool isDevelopment)
    {
        var useInMemoryPageData = isDevelopment;
        var inMemorySetting = configuration["Infrastructure:UseInMemoryPageData"];
        if (bool.TryParse(inMemorySetting, out var parsedSetting))
        {
            useInMemoryPageData = parsedSetting;
        }

        if (useInMemoryPageData)
        {
            services.AddSingleton<IEmployeeRepository, InMemoryEmployeeRepository>();
            services.AddSingleton<IPageDataRepository, InMemoryPageDataRepository>();
            return services;
        }

        services.AddDbContext<HrisDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IEmployeeRepository, SqlEmployeeRepository>();
        services.AddScoped<IPageDataRepository, SqlPageDataRepository>();

        return services;
    }
}
