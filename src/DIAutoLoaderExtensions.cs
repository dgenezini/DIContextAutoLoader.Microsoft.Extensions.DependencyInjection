using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DIContextAutoLoader.Microsoft.Extensions.DependencyInjection
{
    public static class DIAutoLoaderExtensions
    {
        public static IServiceCollection AutoLoadServices(
            this IServiceCollection services,
            params Assembly[] assemblies)
        {
            var InstanceInjectionConfigurarions = ServiceInjectionManager
                .GetServicesInjectionConfigurarions(assemblies);

            foreach (var InstanceInjectionConfigurarion in InstanceInjectionConfigurarions)
            {
                if (InstanceInjectionConfigurarion.Lifetime == InjectionLifetime.Transient)
                {
                    services.AddTransient(InstanceInjectionConfigurarion.ServiceType,
                        InstanceInjectionConfigurarion.ImplementationType);
                }
                else if (InstanceInjectionConfigurarion.Lifetime == InjectionLifetime.Scoped)
                {
                    services.AddScoped(InstanceInjectionConfigurarion.ServiceType,
                        InstanceInjectionConfigurarion.ImplementationType);
                }
                else if (InstanceInjectionConfigurarion.Lifetime == InjectionLifetime.Singleton)
                {
                    services.AddSingleton(InstanceInjectionConfigurarion.ServiceType,
                        InstanceInjectionConfigurarion.ImplementationType);
                }
            }

            return services;
        }
    }
}
