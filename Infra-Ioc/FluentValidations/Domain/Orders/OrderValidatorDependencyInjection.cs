using FluentValidation;
using FluentValidations.Domain.Entities.Orders;
using Microsoft.Extensions.DependencyInjection;

namespace Infra_Ioc.FluentValidations.Domain.Orders;

public static class OrderValidatorDependencyInjection
{
    public static IServiceCollection AddOrderValidatorDependencyInjection(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblyContaining<OrderDetailValidator>();
        services.AddValidatorsFromAssemblyContaining<OrderValidator>();
        return services;
    }
}