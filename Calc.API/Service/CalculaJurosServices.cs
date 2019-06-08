using Calc.API.Models;
using System;

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
            return (Math.Truncate(100 * (pParametrosCalculoDTO.ValorInicial * (decimal)Math.Pow((1 + Juros), (double)pParametrosCalculoDTO.Meses))) / 100).ToString("#0.00");
        }
    }
}
