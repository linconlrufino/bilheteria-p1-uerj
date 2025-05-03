using BilheteriaMain;

namespace Tests
{
    public class BilheteriaTests
    {
        [Theory]
        [InlineData(new int[] { 10, 11, 12, 7, 8}, 50)]     // todos criancas
        [InlineData(new int[] { 10, 8 }, 20)]                // 2 crianças
        [InlineData(new int[] { 30, 40, 50 }, 90)]           // 3 adultos
        [InlineData(new int[] { 20, 21, 22, 27, 28  }, 150)] // todos adultos
        [InlineData(new int[] { 65 }, 15)]                   // 1 idoso
        [InlineData(new int[] { 60, 61, 62, 63, 64 }, 75)]   // todos idosos
        [InlineData(new int[] { 12, 13, 59, 60 }, 85)]       // mistura com limites
        [InlineData(new int[] { 07, 27, 67 }, 55)]           // 3 Variados
        public void CalcularAtendimento_DeveRetornarTotalCorreto(int[] idades, decimal esperado)
        {
            var quantidade = idades.Length;
            var resultado = Bilheteria.CalcularAtendimento(quantidade, idades);
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(new int[] { 5, 25, 70, 49, 49, 39 }, 0)] // quantidade de ingressos superior a 5
        [InlineData(new int[] { }, 0)]                       // quantidade de ingressos igual a 0
        [InlineData(new int[] { 121 }, 0)]                   // idade superior a 120
        [InlineData(new int[] { -1 }, 0)]                       // idade inferior a 0
        public void CalcularAtendimento_ValoresIncorretos_DeveRetornarValorZero(int[] idades, decimal esperado)
        {
            var quantidade = idades.Length;
            var resultado = Bilheteria.CalcularAtendimento(quantidade, idades);
            Assert.Equal(esperado, resultado);
        }
    }
}