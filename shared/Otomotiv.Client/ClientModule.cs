using Microsoft.Extensions.DependencyInjection;
using Otomotiv.Api.Common.IOC;
using Microsoft.Extensions.Configuration;


namespace Otomotiv.Api.Common
{
    public static class ClientModule
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.UseIocLoader();
        }
    }
}
