using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Otomotiv.Api.Common.IOC;

namespace Otomotiv.Api.Brands.Base
{
    public static class BrandBaseModule
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.UseIocLoader();
        }
    }
}
