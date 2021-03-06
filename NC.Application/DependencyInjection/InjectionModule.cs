﻿using Autofac;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NC.Api.GraphQL.Types;
using System.Linq;
using System.Reflection;

namespace NC.Api.DependencyInjection
{
    //public class InjectionModule : Autofac.Module
    //{
    //    private readonly IConfigurationRoot _configuration;
    //    private readonly IServiceCollection _serviceCollection;

    //    public InjectionModule(IServiceCollection serviceCollection, IConfigurationRoot configuration)
    //    {
    //        _serviceCollection = serviceCollection;
    //        _configuration = configuration;
    //    }

    //    protected override void Load(ContainerBuilder builder)
    //    {
    //        //RegisterServices(builder);
    //        //RegisterGraphQLSchema(builder);
    //        RegisterGraphQLTypes(builder);
    //        //RegisterGraphQLQueries(builder);
    //        //RegisterGraphQLResolvers(builder);
    //        //RegisterDepositoryClients(builder);
    //        //RegisterIndexerClients(builder);
    //        //RegisterCrawlerClients(builder);
    //        //RegisterAuthorizationClients(builder);
    //        //RegisterPdfExportClients(builder);
    //    }

    //    //private void RegisterServices(ContainerBuilder builder)
    //    //{
    //    //    var serviceAssembly = typeof(InjectionModule).GetTypeInfo().Assembly;

    //    //    builder.RegisterAssemblyTypes(serviceAssembly)
    //    //        .Where(t => t.Name.EndsWith("Service"))
    //    //        .AsImplementedInterfaces()
    //    //        .InstancePerLifetimeScope();
    //    //}

    //    //private void RegisterGraphQLQueries(ContainerBuilder builder)
    //    //{
    //    //    builder.RegisterType<DocumentExecuter>().As<IDocumentExecuter>();
    //    //    builder.RegisterType<GraphQLQuery>().AsSelf();
    //    //}

    //    private void RegisterGraphQLTypes(ContainerBuilder builder)
    //    {
    //        var serviceAssembly = typeof(InjectionModule).GetTypeInfo().Assembly;
    //        builder.RegisterAssemblyTypes(serviceAssembly)
    //            .Where(t => t.GetInterfaces()
    //                .Any(i => i.IsAssignableFrom(typeof(IGraphQLType))))
    //            .AsSelf();

    //        //builder.RegisterGeneric(typeof(ResponseGraphType<>)).AsSelf();
    //        //builder.RegisterGeneric(typeof(ResponseListGraphType<>)).AsSelf();
    //    }

    //    //private void RegisterGraphQLSchema(ContainerBuilder builder)
    //    //{
    //    //    builder.RegisterType<GraphQLSchema>().As<ISchema>();
    //    //    builder.Register<Func<Type, GraphType>>(c =>
    //    //    {
    //    //        var context = c.Resolve<IComponentContext>();
    //    //        return t => {
    //    //            var res = context.Resolve(t);
    //    //            return (GraphType)res;
    //    //        };
    //    //    });
    //    //}

    //    //private void RegisterGraphQLResolvers(ContainerBuilder builder)
    //    //{
    //    //    var serviceAssembly = typeof(InjectionModule).GetTypeInfo().Assembly;

    //    //    builder.RegisterAssemblyTypes(serviceAssembly)
    //    //        .Where(t => t.Name.EndsWith("Resolver") && t.Name != "Resolver")
    //    //        .AsImplementedInterfaces()
    //    //        .InstancePerLifetimeScope();
    //    //}

    //    //private void RegisterAuthorizationClients(ContainerBuilder builder)
    //    //{
    //    //    var baseAddressParameter = new ResolvedParameter(
    //    //            (pi, ctx) => pi.ParameterType == typeof(string) && pi.Name == "baseAddress",
    //    //            (pi, ctx) => GetServiceAddress(ctx, "authorization"));

    //    //    var customHeadersParameter = new ResolvedParameter(
    //    //            (pi, ctx) => pi.ParameterType == typeof(IHttpContextHeaders) && pi.Name == "customHeaders",
    //    //            (pi, ctx) => GetHttpHeaders(ctx));

    //    //    builder.RegisterType<UsersClient>().As<IUsersClient>()
    //    //        .WithParameter(baseAddressParameter)
    //    //        .WithParameter(customHeadersParameter);
    //    //}

    //    //private void RegisterCrawlerClients(ContainerBuilder builder)
    //    //{
    //    //    var baseAddressParameter = new ResolvedParameter(
    //    //            (pi, ctx) => pi.ParameterType == typeof(string) && pi.Name == "baseAddress",
    //    //            (pi, ctx) => GetServiceAddress(ctx, "crawler"));

    //    //    var customHeadersParameter = new ResolvedParameter(
    //    //            (pi, ctx) => pi.ParameterType == typeof(IHttpContextHeaders) && pi.Name == "customHeaders",
    //    //            (pi, ctx) => GetHttpHeaders(ctx));

    //    //    builder.RegisterType<NightcrawlerClient>().As<INightcrawlerClient>()
    //    //        .WithParameter(baseAddressParameter)
    //    //        .WithParameter(customHeadersParameter);
    //    //}

    //    //private void RegisterDepositoryClients(ContainerBuilder builder)
    //    //{
    //    //    var baseAddressParameter = new ResolvedParameter(
    //    //            (pi, ctx) => pi.ParameterType == typeof(string) && pi.Name == "baseAddress",
    //    //            (pi, ctx) => GetServiceAddress(ctx, "depository"));

    //    //    var customHeadersParameter = new ResolvedParameter(
    //    //            (pi, ctx) => pi.ParameterType == typeof(IHttpContextHeaders) && pi.Name == "customHeaders",
    //    //            (pi, ctx) => GetHttpHeaders(ctx));

    //    //    builder.RegisterType<ProjectsClient>().As<IProjectsClient>()
    //    //        .WithParameter(baseAddressParameter)
    //    //        .WithParameter(customHeadersParameter);

    //    //    builder.RegisterType<BranchesClient>().As<IBranchesClient>()
    //    //        .WithParameter(baseAddressParameter)
    //    //        .WithParameter(customHeadersParameter);

    //    //    builder.RegisterType<DocumentsClient>().As<IDocumentsClient>()
    //    //        .WithParameter(baseAddressParameter)
    //    //        .WithParameter(customHeadersParameter);

    //    //    builder.RegisterType<GroupsClient>().As<IGroupsClient>()
    //    //        .WithParameter(baseAddressParameter)
    //    //        .WithParameter(customHeadersParameter);

    //    //    builder.RegisterType<LogsClient>().As<ILogsClient>()
    //    //        .WithParameter(baseAddressParameter)
    //    //        .WithParameter(customHeadersParameter);
    //    //}

    //    //private void RegisterIndexerClients(ContainerBuilder builder)
    //    //{
    //    //    var baseAddressParameter = new ResolvedParameter(
    //    //            (pi, ctx) => pi.ParameterType == typeof(string) && pi.Name == "baseAddress",
    //    //            (pi, ctx) => GetServiceAddress(ctx, "indexer"));

    //    //    var customHeadersParameter = new ResolvedParameter(
    //    //            (pi, ctx) => pi.ParameterType == typeof(IHttpContextHeaders) && pi.Name == "customHeaders",
    //    //            (pi, ctx) => GetHttpHeaders(ctx));

    //    //    builder.RegisterType<SearchClient>().As<ISearchClient>()
    //    //        .WithParameter(baseAddressParameter)
    //    //        .WithParameter(customHeadersParameter);
    //    //}

    //    //private void RegisterPdfExportClients(ContainerBuilder builder)
    //    //{
    //    //    var baseAddressParameter = new ResolvedParameter(
    //    //            (pi, ctx) => pi.ParameterType == typeof(string) && pi.Name == "baseAddress",
    //    //            (pi, ctx) => GetServiceAddress(ctx, "pdfexport"));

    //    //    var customHeadersParameter = new ResolvedParameter(
    //    //            (pi, ctx) => pi.ParameterType == typeof(IHttpContextHeaders) && pi.Name == "customHeaders",
    //    //            (pi, ctx) => GetHttpHeaders(ctx));

    //    //    builder.RegisterType<PdfExportClient>().As<IPdfExportClient>()
    //    //        .WithParameter(baseAddressParameter)
    //    //        .WithParameter(customHeadersParameter);
    //    //}

    //    //private static IHttpContextHeaders GetHttpHeaders(IComponentContext c)
    //    //{
    //    //    var httpContextAccessor = c.Resolve<IHttpContextAccessor>();
    //    //    var httpHeaders = c.Resolve<IHttpContextHeaders>();
    //    //    var httpContext = httpContextAccessor.HttpContext;

    //    //    IDictionary<string, StringValues> headers = null;
    //    //    if (httpContext != null && httpContext.Request != null)
    //    //    {
    //    //        headers = httpContext.Request.Headers as IDictionary<string, StringValues>;
    //    //    }

    //    //    httpHeaders.Headers = headers;
    //    //    return httpHeaders;
    //    //}

    //    //private static string GetServiceAddress(IComponentContext c, string serviceTag)
    //    //{
    //    //    var logger = c.Resolve<ILogger<InjectionModule>>();
    //    //    try
    //    //    {
    //    //        logger.LogInformation($"Getting address for '{serviceTag}' microservice from cache.");
    //    //        var cacheService = c.Resolve<ICacheService>();

    //    //        if (!cacheService.TryGetService(serviceTag, out Neutrino.Entities.Model.Service instance))
    //    //        {
    //    //            logger.LogInformation($"Getting address for '{serviceTag}' microservice from discovery.");

    //    //            var servicesService = c.Resolve<IServicesService>();
    //    //            instance = servicesService.GetServiceInstanceAsync(serviceTag).GetAwaiter().GetResult();

    //    //            if (instance == null)
    //    //            {
    //    //                logger.LogWarning($"Address for '{serviceTag}' microservice wasn't retrieved from discovery.");
    //    //                return null;
    //    //            }

    //    //            cacheService.AddService(serviceTag, instance);
    //    //        }

    //    //        var address = instance.Address.AppendPathSegment("api/");
    //    //        logger.LogInformation($"Address for '{serviceTag}' microservice was retrieved ({address}).");
    //    //        return address;
    //    //    }
    //    //    catch (Exception exception)
    //    //    {
    //    //        logger.LogError($"Address for '{serviceTag}' microservice wasn't retrieved. There was an exception during retrieving address.");
    //    //        logger.LogError($"Exception: {exception}");
    //    //        if (exception.InnerException != null)
    //    //        {
    //    //            logger.LogError($"Inner exception: {exception.InnerException}");
    //    //        }

    //    //        return null;
    //    //    }
    //    //}
    //}
}

