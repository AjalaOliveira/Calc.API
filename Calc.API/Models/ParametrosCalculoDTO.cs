using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calc.API.Models
{
    public class ParametrosCalculoDTO
    {
        public decimal ValorInicial;
        public int Meses;

        public ParametrosCalculoDTO()
        {
        }

        public ParametrosCalculoDTO(decimal pValorInicial, int pMeses)
        {
            ValorInicial = pValorInicial;
            Meses = pMeses;
        }

    }

}
