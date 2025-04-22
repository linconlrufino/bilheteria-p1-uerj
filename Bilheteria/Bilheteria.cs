namespace Bilheterias;

public static class Bilheteria
{
    const decimal dezReais = 10;
    const decimal quinzeReais = 15;
    const decimal trintaReais = 30;

    public static decimal Atendimento()
    {
        decimal valorTotal = 0;

        Console.WriteLine("Quantidade de Ingressos desejada:");
        int.TryParse(Console.ReadLine(), out int quantidadeIngressos);

        if (quantidadeIngressos is > 5 or < 0)
            Console.WriteLine("Quantidade de Ingressos não permitida");

        for (int i = 0; i < quantidadeIngressos; i++)
        {
            Console.WriteLine("Insira a idade:");
            int.TryParse(Console.ReadLine(), out var idade);
            if (idade <= 12)
                valorTotal += dezReais;
            else if (idade is > 12 and <= 59)
                valorTotal += trintaReais;
            else
                valorTotal += quinzeReais;
            Console.Clear();
        }

        Console.WriteLine("Valor Total: " + valorTotal);
        return valorTotal;
    }
}