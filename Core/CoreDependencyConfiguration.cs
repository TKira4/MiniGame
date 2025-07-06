using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Core;

public static class CoreDependencyConfiguration
{
    public static void AddMediator(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });
    }
}