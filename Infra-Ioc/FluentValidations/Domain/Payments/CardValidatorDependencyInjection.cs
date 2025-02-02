using Domain.Entities.Payments;
using FluentValidation;
using FluentValidations.Domain.Entities.Payments;
using Microsoft.Extensions.DependencyInjection;

namespace Infra_Ioc.FluentValidations.Domain.Payments;

public static class CardValidatorDependencyInjection
{
    public static IServiceCollection AddCardValidatorDependencyInjection(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblyContaining<CardValidator<Card>>();
        services.AddValidatorsFromAssemblyContaining<PaymentMethodValidator<PaymentMethod>>();
        return services;
    }
}