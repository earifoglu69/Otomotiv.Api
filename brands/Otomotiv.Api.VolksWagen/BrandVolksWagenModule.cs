using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Otomotiv.Api.Common.IOC;


namespace Otomotiv.Api.Brands.VolksWagen
{
    public static class BrandVolksWagenModule
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.UseIocLoader();
        }
    }
}
