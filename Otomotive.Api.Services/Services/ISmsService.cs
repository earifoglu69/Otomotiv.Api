using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomotiv.Application.Services
{
    public interface ISmsService
    {
        Task<string> GenerateCustomerSmsCode(int brandId);
    }
}
