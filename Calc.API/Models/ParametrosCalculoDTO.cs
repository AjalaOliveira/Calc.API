using System;
using System.Collections.Generic;
using System.Globalization;
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

        public String ValidarParametros()
        {
            string Resultado = null;
            var Estilo = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
            var Ccultura = CultureInfo.CreateSpecificCulture("pt-BR");

            //Verifica se ValorInicial é um número decimal válido e se é maior que zero (0).
            if (!Decimal.TryParse(ValorInicial.ToString(), Estilo, Ccultura, out _))
            {
                Resultado = "O valor '" + ValorInicial.ToString() + "' atribuido ao parâmetro 'ValorInicial' deve ser um número decimal válido.\n";
            }
            else if (ValorInicial<=0)
            {
                Resultado += "O valor atribuido ao parâmetro 'ValorInicial' deve ser um número decimal maior que zero (0).\n";
            }

            //Verifica se Meses é um número decimal válido e se é maior que zero (0).
            if (!Int32.TryParse(Meses.ToString(), Estilo, Ccultura, out _))
            {
                Resultado = "O valor '" + Meses.ToString() + "' atribuido ao parâmetro 'Meses' deve ser um número inteiro válido.\n";
            }
            else if (Meses <= 0)
            {
                Resultado += "O valor atribuido ao parâmetro 'Meses' deve ser um número inteiro maior que zero (0).";
            }

            return Resultado;
        }


    }

}
