using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomotiv.Api.Brands.Seat.Services
{
    public interface ISeatSmsService
    {
        Task<string> ExtraSeatSmsMethod();

    }
}
