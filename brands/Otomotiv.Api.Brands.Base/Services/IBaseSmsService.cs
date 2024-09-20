using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomotiv.Api.Brands.Base.Services
{
    public interface IBaseSmsService
    {
        Task<string> GenerateSmsCode();
    }
}
