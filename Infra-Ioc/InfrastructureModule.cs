using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra_Ioc;

public static class InfrastructureModule
{
    public static void AddInfrastructureModule(this IServiceCollection service,
        IConfiguration configuration)
    {
        service.AddDatabaseDependencyInjection(configuration);
    } 
}