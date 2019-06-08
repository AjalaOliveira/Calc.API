using Calc.API.Models;
using Xunit;

namespace Calc.API.Teste.Unidade
{
    public class ParametrosCalculoDTOTeste
    {
        //TESTE PARA VALIDAR VALOR INICIAL MENOR OU IGUAL A ZERO (0).
        //ValorInicial = 0
        //mes = 5
        [Fact]
        public void ParametrosCalculoDTO_ValidarParametros_ValorInicialMenorQueZero()
        {
            // Arrange
            ParametrosCalculoDTO parametrosCalculoDTO = new ParametrosCalculoDTO(0, 5);

            //Act
            var result = parametrosCalculoDTO.ValidarParametros();

            //Assert
            Assert.Contains("O valor atribuido ao parâmetro 'ValorInicial' deve ser um número decimal maior que zero (0).", result);
        }

        //TESTE PARA VALIDAR MES MENOR OU IGUAL A ZERO (0).
        //ValorInicial = 5
        //mes = 0
        [Fact]
        public void ParametrosCalculoDTO_ValidarParametros_MesMenorQueZero()
        {
            // Arrange
            ParametrosCalculoDTO parametrosCalculoDTO = new ParametrosCalculoDTO(5, 0);

            //Act
            var result = parametrosCalculoDTO.ValidarParametros();

            //Assert
            Assert.Contains("O valor atribuido ao parâmetro 'Meses' deve ser um número inteiro maior que zero (0).", result);
        }

        //TESTE PARA VALIDAR VALOR INICIAL E MES MENOR OU IGUAL A ZERO (0).
        //ValorInicial = 0
        //mes = 0
        [Fact]
        public void ParametrosCalculoDTO_ValidarParametros_ValorInicialEMesMenorQueZero()
        {
            // Arrange
            ParametrosCalculoDTO parametrosCalculoDTO = new ParametrosCalculoDTO(0, 0);

            //Act
            var result = parametrosCalculoDTO.ValidarParametros();

            //Assert
            Assert.Contains("O valor atribuido ao parâmetro 'ValorInicial' deve ser um número decimal maior que zero (0).\n" +
                "O valor atribuido ao parâmetro 'Meses' deve ser um número inteiro maior que zero (0).", result);
        }
    }
}
