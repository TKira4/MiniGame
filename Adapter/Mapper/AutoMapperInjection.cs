using System.Reflection;
using Adapter.Models;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Adapter.Mapper;

public static class AutoMapperInjection
{
    public static void AddMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    }
}   