using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Shared.Core;

public static class ServiceCollectionExt
{
    // rename this to AddSharedCoreService
    public static void AddCoreServices(this IServiceCollection services, Assembly currentAssembly)
    {
        ValidatorOptions.Global.DefaultRuleLevelCascadeMode = CascadeMode.Stop;
        services.AddValidatorsFromAssembly(currentAssembly);
    }
}