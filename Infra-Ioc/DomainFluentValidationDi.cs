﻿using FluentValidation.AspNetCore;
using Infra_Ioc.FluentValidations.Domain.Cart;
using Infra_Ioc.FluentValidations.Domain.Deliveries;
using Infra_Ioc.FluentValidations.Domain.Identity;
using Infra_Ioc.FluentValidations.Domain.ObjectValues;
using Infra_Ioc.FluentValidations.Domain.Orders;
using Infra_Ioc.FluentValidations.Domain.Payments;
using Infra_Ioc.FluentValidations.Domain.Products.Fashion.ObjectValues;
using Infra_Ioc.FluentValidations.Domain.Products.Technology.ObjectValues;
using Infra_Ioc.FluentValidations.Domain.Reviews;
using Microsoft.Extensions.DependencyInjection;

namespace Infra_Ioc;

public static class DomainFluentValidationDi
{
    public static void AddDomainFluentValidationDi(this IServiceCollection services)
    {
        services.AddShirtObjectValuesValidator();
        services.AddShoeObjectValuesValidator();
        services.AddGameObjectValuesValidator();
        services.AddSmartphoneObjectValuesValidator();
        services.AddCardValidatorDependencyInjection();
        services.AddOrderValidatorDependencyInjection();
        services.AddProductObjectValueValidator();
        services.AddUserDeliveryObjectValueValidator();
        services.AddShoppingCartItemValidatorDi();
        services.AddReviewValidatorDi();
        services.AddIdentityValidatorDi();
      
        services.AddFluentValidationAutoValidation();
    }
}