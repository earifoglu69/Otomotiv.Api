using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Otomotiv.Api.Common.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomotiv.Api.Brands.Seat
{
    public static class SeatModule
    {
        public static void Configure(IServiceCollection services, ConfigurationManager configuration)
        {
            IocLoader.UseIocLoader(services);
        }
    }
}
