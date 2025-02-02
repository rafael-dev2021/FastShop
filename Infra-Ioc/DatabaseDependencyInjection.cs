using Infra_Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra_Ioc;

public static class DatabaseDependencyInjection
{
    public static void AddDatabaseDependencyInjection(this IServiceCollection service,
        IConfiguration configuration)
    {
        service.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                x =>
                    x.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));
    }
}