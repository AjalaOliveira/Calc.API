using Calc.API.Service;
using Xunit;

namespace Calc.API.Teste.Unidade
{
    public class ApresentaCodigoServiceTeste
    {

        [Fact]
        public void ApresentaCodigoService_ShowMeTheCode_Sucesso()
        {
            // Arrange
            ApresentaCodigoService apresentaCodigoService = new ApresentaCodigoService();

            //Act
            var result = apresentaCodigoService.ShowMeTheCode();

            //Assert
            Assert.Contains("https://github.com/AjalaOliveira/Calc.API", result);
        }
    }
}
