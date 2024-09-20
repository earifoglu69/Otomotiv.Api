using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Otomotiv.Api.Common.IOC;


namespace Otomotiv.Api.Brands.Audi
{
    public static class BrandAudiModule
    {
        public static void Configure(IServiceCollection services, ConfigurationManager configuration)
        {
            services.UseIocLoader();
        }
    }
}
