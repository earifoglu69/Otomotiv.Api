using Microsoft.Extensions.DependencyInjection;
using Otomotiv.Api.Brands.Audi.Services;
using Otomotiv.Api.Brands.Base.Services;
using Otomotiv.Api.Common.IOC;
using Otomotiv.Infrastructure.Models;
using Otomotiv.Infrastructure.UnitOfWork;

namespace Otomotiv.Application.Services
{
    public class SmsService : ISmsService, IScopedService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceProvider _serviceProvider;

        public SmsService(IUnitOfWork unitOfWork, IServiceProvider serviceProvider)
        {
            _unitOfWork=unitOfWork;
            _serviceProvider=serviceProvider;
        }

        public async Task<string> GenerateCustomerSmsCode(int brandId)
        {
            var brandEntity = await _unitOfWork.GetRepository<BrandEntity>().GetByIdAsync(brandId);

            var services = _serviceProvider.GetServices<IBaseSmsService>();
            var servicePayment = services.First(o => o.GetType().Name == $"{brandEntity.Name}SmsService");

            var smsCode = await servicePayment.GenerateSmsCode();

            var brandSettings =  await _unitOfWork.GetRepository<BrandSettingEntity>().GetAllAsync(x => x.BrandId == brandId);
            return smsCode;
        }
    }
}
