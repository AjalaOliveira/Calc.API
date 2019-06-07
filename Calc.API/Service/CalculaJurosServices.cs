using Calc.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calc.API.Service
{
    public class CalculaJurosServices
    {
        private static double Juros = 0.01;

        public CalculaJurosServices()
        {

        }

        public String CalcularJurosComposto(ParametrosCalculoDTO pParametrosCalculoDTO)
        {
            ResultadoJurosCompostoDTO resultadoJurosCompostoDTO = new ResultadoJurosCompostoDTO();
            resultadoJurosCompostoDTO.Resultado = Math.Truncate(100 * (pParametrosCalculoDTO.ValorInicial * (decimal)Math.Pow((1+Juros), (double)pParametrosCalculoDTO.Meses))) / 100;
            return resultadoJurosCompostoDTO.Resultado.ToString("#0.00");
        }
    }
}
