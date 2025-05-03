using BilheteriaMain;

Console.WriteLine("Quantidade de Ingressos desejada:");
int.TryParse(Console.ReadLine(), out int quantidadeIngressos);

if (quantidadeIngressos is > 5 or < 0){
    Console.WriteLine("Quantidade de Ingressos não permitida");
    return;
}

var idades =  new int[quantidadeIngressos];

for (int i = 0; i < quantidadeIngressos; i++)
{
    Console.WriteLine("Insira a idade:");
    int.TryParse(Console.ReadLine(), out idades[i]);
    Console.Clear();
}

var valorTotal = Bilheteria.CalcularAtendimento(quantidadeIngressos, idades);

Console.WriteLine("Valor Total: R$ " + valorTotal.ToString("F2"));