using Microsoft.Extensions.Options;
using Otomotiv.Api.Common.IOC;
using Otomotiv.Api.Common.Settings;
using Otomotiv.Api.Common.TurkuazModels;
using Otomotiv.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomotiv.External.Turkuaz.Services
{
    public class VehicleService : IVehicleService, IScopedService
    {
        private readonly IOptions<TurkuazClientSetting> _options;
        public VehicleService(IOptions<TurkuazClientSetting> options)
        {
            _options=options;
        }

        public async Task<string> GetVehiclesInfoAsync()
        {
            string url = $"{_options.Value.BaseAddress}/OnlineAppointment/Appointment/List/??code=121233&licencePlate=34KM21234";
            var restClient = new ClientService<object, ListVehicleResponse>();
            var response = await restClient.RestClientGetAsync(url, null);

            return response?.Header?.Message??"";
        }
    }
}
