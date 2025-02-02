using Domain.Interfaces.Products.Technology;
using Infra_Data.Repositories.Products.Technology;
using Microsoft.Extensions.DependencyInjection;

namespace Infra_Ioc.Domain.Products.Technology;

public static class TechnologyDependencyInjection
{
    public static void AddTechnologyDependencyInjection(this IServiceCollection services)
    {
        services.AddScoped<IGameRepository, GameRepository>();
        services.AddScoped<ISmartphoneRepository, SmartphoneRepository>();
    }
}