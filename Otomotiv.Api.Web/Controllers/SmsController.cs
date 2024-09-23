using Microsoft.AspNetCore.Mvc;
using Otomotiv.Application.Services;

namespace Otomotiv.Api.Web.Controllers
{
    public class SmsController : BaseController<SmsController>
    {
        private readonly ISmsService _smsService;

        public SmsController(ISmsService smsService)
        {
            _smsService=smsService;
        }

        [HttpGet("{brandId}")]
        public async Task<IActionResult> GenerateCustomerSmsCode(int brandId)
        {
            var response = await _smsService.GenerateCustomerSmsCode(brandId);
            return Ok(response);
        }

        [HttpGet("AudiExtraMethod")]
        public async Task<IActionResult> AudiExtraMethod()
        {
            var response = await _smsService.AudiExtraMethod();
            return Ok(response);
        }
        [HttpGet("SeatExtraMethod")]
        public async Task<IActionResult> SeatExtraMethod()
        {
            var response = await _smsService.SeatExtraMethod();
            return Ok(response);
        }
    }
}
