using System.Threading.Tasks;
using Xunit;

namespace Calc.API.Teste.Integracao.Testes
{
    public class CalculaJurosControllerTeste
    {
        public CalculaJurosControllerTeste()
        {
            Ambiente.CreateServer();
        }

        //TESTE COM O VALORES INFORMADOS NO EXEMPLO DO DESAFIO.
        //ValorInicial = 100
        //mes = 5
        //resultado = 105,10
        [Fact]
        public async Task CalculaJurosController_CalcularJuros_Sucesso()
        {
            // Arrange
            var valorinicial = 100;
            var meses = 5;

            // Act
            var result = await Ambiente.Client.GetStringAsync("/calculajuros?valorinicial="+ valorinicial + "&meses=" + meses);

            // Assert

            Assert.Contains("105,10", result);
        }


        //TESTE PARA VALIDAR O REQUISITO DE NÃO REALIZAR O ARREDONDAMENTO DO VALOR DO RESULTADO DO CÁLCULO.
        //ValorInicial = 100
        //mes = 8
        //resultado = 108.28567056280800M {{ANTES DE APLICAR A FUNÇÃO TRUNCATE}}
        [Fact]
        public async Task CalculaJurosController_CalcularJuros_NaoArredondarResultado()
        {
            // Arrange
            var valorinicial = 100;
            var meses = 8;

            //Act
            var result = await Ambiente.Client.GetStringAsync("/calculajuros?valorinicial=" + valorinicial + "&meses=" + meses);

            //Assert
            Assert.Contains("108,28", result);
        }

        //TESTE PARA VALIDAR VALOR INICIAL MENOR OU IGUAL A ZERO (0).
        //ValorInicial = 0
        //mes = 5
        [Fact]
        public async Task CalculaJurosController_CalcularJuros_ValorInicialMenorQueZero()
        {
            // Arrange
            var valorinicial = 0;
            var meses = 5;

            //Act
            var result = await Ambiente.Client.GetStringAsync("/calculajuros?valorinicial=" + valorinicial + "&meses=" + meses);

            //Assert
            Assert.Contains("O valor atribuido ao parâmetro 'ValorInicial' deve ser um número decimal maior que zero (0).", result);
        }

        //TESTE PARA VALIDAR VALOR INICIAL MENOR OU IGUAL A ZERO (0).
        //ValorInicial = 0
        //mes = 5
        [Fact]
        public async Task CalculaJurosController_CalcularJuros_MesMenorQueZero()
        {
            // Arrange
            var valorinicial = 5;
            var meses = 0;

            //Act
            var result = await Ambiente.Client.GetStringAsync("/calculajuros?valorinicial=" + valorinicial + "&meses=" + meses);

            //Assert
            Assert.Contains("O valor atribuido ao parâmetro 'Meses' deve ser um número inteiro maior que zero (0).", result);
        }

        //TESTE PARA VALIDAR VALOR INICIAL E MES MENOR OU IGUAL A ZERO (0).
        //ValorInicial = 0
        //mes = 0
        [Fact]
        public async Task CalculaJurosController_CalcularJuros_ValorInicialEMesMenorQueZero()
        {
            // Arrange
            var valorinicial = 0;
            var meses = 0;

            //Act
            var result = await Ambiente.Client.GetStringAsync("/calculajuros?valorinicial=" + valorinicial + "&meses=" + meses);

            //Assert
            Assert.Contains("O valor atribuido ao parâmetro 'ValorInicial' deve ser um número decimal maior que zero (0).\n" +
                "O valor atribuido ao parâmetro 'Meses' deve ser um número inteiro maior que zero (0).", result);
        }

        //TESTE PARA VALIDAR O REQUISITO DE SEJA PASSADO UM VALOR DO TIPO DECIMAL PARA INFORMAR O VALOR INICIAL.
        //ValorInicial = "ABC"
        //mes = 1
        [Fact]
        public async Task CalculaJurosController_CalcularJuros_ValorInicialNaoEUmDecimal()
        {
            // Arrange
            var valorinicial = "ABC";
            var meses = 0;

            //Act
            var result = await Ambiente.Client.GetAsync("/calculajuros?valorinicial=" + valorinicial + "&meses=" + meses);

            //Assert
            Assert.Contains("BadRequest", result.StatusCode.ToString());
        }

        //TESTE PARA VALIDAR O REQUISITO DE SEJA PASSADO UM VALOR DO TIPO INTEIRO PARA INFORMAR OS MESES.
        //ValorInicial = 100
        //mes = 1.1
        [Fact]
        public async Task CalculaJurosController_CalcularJuros_MesesNaoEUmInteiro()
        {
            // Arrange
            var valorinicial = 100;
            var meses = 1.1;

            //Act
            var result = await Ambiente.Client.GetAsync("/calculajuros?valorinicial=" + valorinicial + "&meses=" + meses);

            //Assert
            Assert.Contains("BadRequest", result.StatusCode.ToString());
        }

        //TESTE PARA VALIDAR VALOR INICIAL NÃO INFORMADO
        //ValorInicial = 
        //mes = 1
        [Fact]
        public async Task CalculaJurosController_CalcularJuros_ValorInicialNaoInformado()
        {
            // Arrange
            var valorinicial = string.Empty;
            var meses = 1;

            //Act
            var result = await Ambiente.Client.GetAsync("/calculajuros?valorinicial=" + valorinicial + "&meses=" + meses);

            //Assert
            Assert.Contains("BadRequest", result.StatusCode.ToString());
        }

        //TESTE PARA VALIDAR MESES NÃO INFORMADO
        //ValorInicial = 100
        //mes = 
        [Fact]
        public async Task CalculaJurosController_CalcularJuros_MesesNaoInformado()
        {
            // Arrange
            var valorinicial = 100;
            var meses = string.Empty;

            //Act
            var result = await Ambiente.Client.GetAsync("/calculajuros?valorinicial=" + valorinicial + "&meses=" + meses);

            //Assert
            Assert.Contains("BadRequest", result.StatusCode.ToString());
        }

        //TESTE PARA VALIDAR VALOR INICIAL E MESES NÃO INFORMADO
        //ValorInicial = 
        //mes = 
        [Fact]
        public async Task CalculaJurosController_CalcularJuros_ValorInicialEMesesNaoInformados()
        {
            // Arrange
            var valorinicial = string.Empty;
            var meses = string.Empty; 

            //Act
            var result = await Ambiente.Client.GetAsync("/calculajuros?valorinicial=" + valorinicial + "&meses=" + meses);

            //Assert
            Assert.Contains("BadRequest", result.StatusCode.ToString());
        }
    }
}

