using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calc.API.Models;
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
            return "https://github.com/AjalaOliveira/Calc.API";
        }
    }
}
