using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomotiv.External.Turkuaz.Services
{
    public interface IVehicleService
    {
        Task<string> GetVehiclesInfoAsync();
    }
}
