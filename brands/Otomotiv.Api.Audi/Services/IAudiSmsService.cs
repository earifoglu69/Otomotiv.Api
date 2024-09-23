using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomotiv.Api.Brands.Audi.Services
{
    public interface IAudiSmsService
    {
        Task<string> ExtraAudiSmsMethod();
    }
}
