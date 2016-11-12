using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;
using WorkMarket.DI.Registration;
using WorkMarket.Providers;

namespace WorkMarket.App_Start
{
    public class AutofacConfig
    {
        public static IContainer RegisterDependencies(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            // autowire
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                    .InstancePerDependency();

            // make controllers use constructor injection
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // register dependencies from BL, DAL and other modules
            var dependencyModule = new DependencyModule();
            builder.RegisterModule(dependencyModule);

            builder.RegisterType<SimpleAuthorizationServerProvider>()
                .As<ISimpleAuthorizationServerProvider>()
                .PropertiesAutowired()
                .SingleInstance();
                        

            var container = builder.Build();
            // Configure Web API with the dependency resolver.
            var resolver = new AutofacWebApiDependencyResolver(container);            
            config.DependencyResolver = resolver;

            return container;
        }
    }
}

