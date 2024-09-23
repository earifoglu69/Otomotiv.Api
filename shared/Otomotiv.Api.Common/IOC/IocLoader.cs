using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Otomotiv.Api.Common.IOC
{
    public static class IocLoader
    {
        public static void UseIocLoader(this IServiceCollection serviceCollection)
        {
            var transientType = typeof(ITransientService);
            var scopedType = typeof(IScopedService);
            var singletonType = typeof(ISingletonService);

            var services = Assembly.GetCallingAssembly()
                .GetTypes()
                .Where(p =>
                        transientType.IsAssignableFrom(p) ||
                        scopedType.IsAssignableFrom(p) ||
                        singletonType.IsAssignableFrom(p)
                      );

            foreach (var service in services)
            {
                var interfaceOfServices = service.GetInterfaces().Where(x => x != transientType && x != scopedType && x != singletonType).ToList();
                foreach (var interfaceOfService in interfaceOfServices)
                {
                    if (transientType.IsAssignableFrom(service))
                    {
                        if (interfaceOfService == null)
                            serviceCollection.AddTransient(service);
                        else
                            serviceCollection.AddTransient(interfaceOfService, service);
                    }

                    else if (scopedType.IsAssignableFrom(service))
                    {
                        if (interfaceOfService == null)
                            serviceCollection.AddScoped(service);
                        else
                            serviceCollection.AddScoped(interfaceOfService, service);
                    }

                    else if (singletonType.IsAssignableFrom(service))
                    {
                        if (interfaceOfService == null)
                            serviceCollection.AddSingleton(service);
                        else
                            serviceCollection.AddSingleton(interfaceOfService, service);
                    }
                }
            }

        }
    }
}
