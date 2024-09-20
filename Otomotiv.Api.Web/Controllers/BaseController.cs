using Microsoft.AspNetCore.Mvc;

namespace Otomotiv.Api.Web.Controllers
{
    [ApiController, Route("api/[controller]")]
    public abstract class BaseController<T> : ControllerBase
    {
        private ILogger<T> _log;
        protected ILogger<T> _logger => _log ??= HttpContext.RequestServices.GetService<ILogger<T>>();
    }
}
