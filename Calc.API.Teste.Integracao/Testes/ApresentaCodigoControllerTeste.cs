using System.Threading.Tasks;
using Xunit;

namespace Calc.API.Teste.Integracao.Testes
{
    public class ApresentaCodigoControllerTeste
    {

        public ApresentaCodigoControllerTeste()
        {
            Ambiente.CreateServer();
        }

        //TESTE PARA VALIDAR O REQUISITO DE APRESENTAR O ENDEREÇO DO REPOSITÓRIO DO CÓDIGO NO GITHUB
        [Fact]
        public async Task ApresentaCodigoController_ShowMeTheCode()
        {
            // Arrange

            // Act
            var result = await Ambiente.Client.GetStringAsync("/showmethecode");

            // Assert

            Assert.Contains("https://github.com/AjalaOliveira/Calc.API", result);
        }

    }
}
