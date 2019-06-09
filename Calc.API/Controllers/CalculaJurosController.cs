using System;
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
            [FromQuery(Name = "valorinicial")] decimal pValorinicial,
            [FromQuery(Name = "meses")] int pMeses
            )
        {
            ParametrosCalculoDTO pParametrosCalculoDTO = new ParametrosCalculoDTO();
            pParametrosCalculoDTO.ValorInicial = pValorinicial;
            pParametrosCalculoDTO.Meses = pMeses;

            if (String.IsNullOrEmpty(pParametrosCalculoDTO.ValidarParametros()))
            {
                CalculaJurosServices calculaJurosServices = new CalculaJurosServices();
                return calculaJurosServices.CalcularJurosComposto(pParametrosCalculoDTO).ToString();
            }

            return pParametrosCalculoDTO.ValidarParametros();
        }
    }
}
