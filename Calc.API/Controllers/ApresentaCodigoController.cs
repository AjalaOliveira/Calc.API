using Calc.API.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Calc.API.Controllers
{

    [ApiController]
    public class ApresentaCodigoController : ControllerBase
    {
        // GET /showmethecode 
        [HttpGet]
        [AllowAnonymous]
        [Route("showmethecode")]
        public ActionResult<string> ShowMeTheCode()
        {
            ApresentaCodigoService apresentaCodigoService = new ApresentaCodigoService();
            return apresentaCodigoService.ShowMeTheCode();
        }
    }
}
