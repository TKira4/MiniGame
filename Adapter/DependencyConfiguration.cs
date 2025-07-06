using Adapter.Mapper;
using Core;
using Microsoft.Extensions.DependencyInjection;

namespace Adapter;

public static class CoreDependencyConfiguration
{
    public static void AddCoreServices(this IServiceCollection services)
    {
        services.AddTransient(typeof(ISender<,>), typeof(Sender<,>));
        services.AddMediator();
        services.AddMapper();
    }
}

