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
    public class CalculaJurosController : ControllerBase
    {
        // GET /calculajuros
        [HttpGet]
        [AllowAnonymous]
        [Route("calculajuros")]
        public ActionResult<string> CalculaJuros(
            [FromQuery(Name = "ValorInicial")] decimal pValorinicial,
            [FromQuery(Name = "Meses")] int pMeses
            )
        {
            ParametrosCalculoDTO pParametrosCalculoDTO = new ParametrosCalculoDTO();
            pParametrosCalculoDTO.ValorInicial = pValorinicial;
            pParametrosCalculoDTO.Meses = pMeses;
            CalculaJurosServices calculaJurosServices = new CalculaJurosServices();
            return calculaJurosServices.CalcularJurosComposto(pParametrosCalculoDTO).ToString();
        }
    }
}
