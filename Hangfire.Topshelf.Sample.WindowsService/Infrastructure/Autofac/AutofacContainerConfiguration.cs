using Autofac;
using Autofac.Extensions.DependencyInjection;
using Hangfire.Topshelf.Sample.WindowsService.WindowsService;
using Microsoft.Extensions.DependencyInjection;

namespace Hangfire.Topshelf.Sample.WindowsService.Infrastructure.Autofac
{
    public class AutofacContainerConfiguration
    {
        public void RegisterServices()
        {
            var serviceCollection = new ServiceCollection();

            var containerBuilder = new ContainerBuilder();
            containerBuilder.Populate(serviceCollection);

            containerBuilder.RegisterType<WindowsServiceBuilder>().As<IWindowsServiceBuilder>().InstancePerLifetimeScope();

            var container = containerBuilder.Build();
            var serviceProvider = new AutofacServiceProvider(container);
        }
    }
}
