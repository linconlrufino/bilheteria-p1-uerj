namespace BilheteriaMain;

public static class Bilheteria
{
    const decimal dezReais = 10;
    const decimal quinzeReais = 15;
    const decimal trintaReais = 30;

    public static decimal CalcularAtendimento(int quantidadeDePessoas, int[] idades)
    {
        decimal valorTotal = 0;

        if (quantidadeDePessoas is > 5 or < 0)
        {
            Console.WriteLine("Quantidade de Ingressos não permitida");
            return 0;
            //throw new Exception("Quantidade de Ingressos não permitida");
        }

        for (int i = 0; i < quantidadeDePessoas; i++)
        {
            if (idades[i] <= 12)
                valorTotal += dezReais;
            else if (idades[i] is > 12 and <= 59)
                valorTotal += trintaReais;
            else
                valorTotal += quinzeReais;
        }

        return valorTotal;
    }
}