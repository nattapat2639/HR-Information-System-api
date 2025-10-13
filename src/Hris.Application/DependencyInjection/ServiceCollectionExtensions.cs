using Hris.Application.Interfaces.Services;
using Hris.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Hris.Application.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddScoped<IPageDataService, PageDataService>();
        services.AddScoped<IEmployeeFieldDefinitionService, EmployeeFieldDefinitionService>();
        services.AddScoped<IEmployeeFieldValueService, EmployeeFieldValueService>();
        return services;
    }
}
