using BilheteriaMain;

namespace Tests
{
    public class BilheteriaTests
    {
        //MethodName_StateUnderTest_ExpectedBehavior

        [Fact]
        public void CalcularAtendimento_TodosMenoresDeIdade_RetornaValor50()
        {
            //Arrange
            int[] idades = [10, 11, 12, 7, 8];
            int quantidadeDeIngressos = 5;

            //Act
            var valorTotal = Bilheteria.CalcularAtendimento(quantidadeDeIngressos, idades);

            //Assert
            Assert.Equal(50, valorTotal);
        }

        [Fact]
        public void CalcularAtendimento_TodosMaioresDeIdade_RetornaValor150()
        {
            //Arrange
            int[] idades = [20, 21, 22, 27, 28];
            int quantidadeDeIngressos = 5;

            //Act
            var valorTotal = Bilheteria.CalcularAtendimento(quantidadeDeIngressos, idades);

            //Assert
            Assert.Equal(150, valorTotal);
        }

        [Fact]
        public void CalcularAtendimento_TodosMaioresIdosos_RetornaValor150()
        {
            //Arrange
            int[] idades = [60, 61, 62, 63, 64];
            int quantidadeDeIngressos = 5;

            //Act
            var valorTotal = Bilheteria.CalcularAtendimento(quantidadeDeIngressos, idades);

            //Assert
            Assert.Equal(75, valorTotal);
        }


        [Fact]
        public void CalcularAtendimento_IdadesVariadas_RetornaValor150()
        {
            //Arrange
            int[] idades = [07, 27, 67];
            int quantidadeDeIngressos = 3;

            //Act
            var valorTotal = Bilheteria.CalcularAtendimento(quantidadeDeIngressos, idades);

            //Assert
            Assert.Equal(55, valorTotal);
        }
    }
}