using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;


namespace NexcodeControls.Api.DependencyInjection
{
    //public static class ServiceCollectionExtensions
    //{
    //    public static IServiceProvider AddApplicationModules(this IServiceCollection serviceCollection, IConfigurationRoot configuration)
    //    {
    //        var builder = new ContainerBuilder();

    //        builder.RegisterModule(new InjectionModule(serviceCollection, configuration));
    //        builder.Populate(serviceCollection);

    //        var container = builder.Build();
    //        return container.Resolve<IServiceProvider>();
    //    }
    //}
}
