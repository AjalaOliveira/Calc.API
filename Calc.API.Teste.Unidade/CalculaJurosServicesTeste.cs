using Calc.API.Models;
using Calc.API.Service;
using Xunit;

namespace Calc.API.Teste.Unidade
{
    public class CalculaJurosServicesTeste
    {

        //TESTE COM O VALORES INFORMADOS NO EXEMPLO DO DESAFIO.
        //ValorInicial = 100
        //mes = 5
        //resultado = 105,10
        [Fact]
        public void CalculaJurosServices_CalcularJurosComposto_Sucesso()
        {
            // Arrange
            ParametrosCalculoDTO parametrosCalculoDTO = new ParametrosCalculoDTO(100, 5);
            CalculaJurosServices CalculaJurosServices = new CalculaJurosServices();

            //Act
            var result = CalculaJurosServices.CalcularJurosComposto(parametrosCalculoDTO);

            //Assert
            Assert.Contains("105,10", result);
        }

        //TESTE PARA VALIDAR O REQUISITO DE NÃO REALIZAR O ARREDONDAMENTO DO VALOR DO RESULTADO DO CÁLCULO.
        //ValorInicial = 100
        //mes = 8
        //resultado = 108.28567056280800M {{ANTES DE APLICAR A FUNÇÃO TRUNCATE}}
        [Fact]
        public void CalculaJurosServices_CalcularJurosComposto_NaoArredondarResultado()
        {
            // Arrange
            ParametrosCalculoDTO parametrosCalculoDTO = new ParametrosCalculoDTO(100, 8);
            CalculaJurosServices CalculaJurosServices = new CalculaJurosServices();

            //Act
            var result = CalculaJurosServices.CalcularJurosComposto(parametrosCalculoDTO);

            //Assert
            Assert.Contains("108,28", result);
        }

    }
}
