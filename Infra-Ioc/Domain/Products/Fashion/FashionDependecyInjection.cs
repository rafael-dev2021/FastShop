using Domain.Interfaces.Products.Fashion;
using Infra_Data.Repositories.Products.Fashion;
using Microsoft.Extensions.DependencyInjection;

namespace Infra_Ioc.Domain.Products.Fashion;

public static class FashionDependencyInjection
{
    public static void AddFashionDependencyInjection(this IServiceCollection services)
    {
        services.AddScoped<IShoesRepository, ShoesRepository>();
        services.AddScoped<IShirtRepository, ShirtRepository>();
    }
}