using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Otomotiv.Api.Common.IOC;

namespace Otomotiv.External.Turkuaz
{
    public static class TurkuazModule
    {
        public static void Configure(IServiceCollection services, ConfigurationManager configuration)
        {
            services.UseIocLoader();
        }
    }
}
