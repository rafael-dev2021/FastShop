using System.Globalization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;

namespace Infra_Ioc;

public static class EnUsCultureInfoDi
{
    public static void AddEnUsCultureInfoDi(this IServiceCollection services)
    {
        services.AddLocalization(opt => opt.ResourcesPath = "Resources");
        var cultureInfo = new CultureInfo("en-US");
        cultureInfo.NumberFormat.CurrencySymbol = "$";
        CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
        CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

        var supportedCultures = new[]
        {
            cultureInfo
        };

        _ = new RequestLocalizationOptions
        {
            DefaultRequestCulture = new RequestCulture("en-US"),
            SupportedCultures = supportedCultures,
            SupportedUICultures = supportedCultures
        };
    }
}

