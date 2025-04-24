namespace BilheteriaMain;

public static class Bilheteria
{
    private const decimal DezReais = 10;
    private const decimal QuinzeReais = 15;
    private const decimal TrintaReais = 30;

    public static decimal CalcularAtendimento(int quantidadeDePessoas, int[] idades)
    {
        decimal valorTotal = 0;

        if (quantidadeDePessoas is > 5 or < 0)
        {
            Console.WriteLine("Quantidade de Ingressos não permitida");
            return 0;
        }

        for (int i = 0; i < quantidadeDePessoas; i++)
        {
            if (idades[i] is < 0 || idades[i] > 120)
            {
                Console.WriteLine("Idade inválida.");
                return 0;
            }
            
            if (idades[i] <= 12)
                valorTotal += DezReais;
            else if (idades[i] is > 12 and <= 59)
                valorTotal += TrintaReais;
            else
                valorTotal += QuinzeReais;
        }

        return valorTotal;
    }
}