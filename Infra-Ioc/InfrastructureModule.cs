using Infra_Ioc.Domain;
using Infra_Ioc.Domain.Products.Fashion;
using Infra_Ioc.Domain.Products.Technology;
using Infra_Ioc.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra_Ioc;

public static class InfrastructureModule
{
    public static void AddInfrastructureModule(this IServiceCollection service,
        IConfiguration configuration)
    {
        service.AddDatabaseDependencyInjection(configuration);
        service.AddEntitiesRepositoryDependencyInjection();
        service.AddTechnologyDependencyInjection();
        service.AddFashionDependencyInjection();
        service.AddIdentityRulesDependencyInjection();
    }
}