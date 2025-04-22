using BilheteriaMain;

Console.WriteLine("Quantidade de Ingressos desejada:");
int.TryParse(Console.ReadLine(), out int quantidadeIngressos);

var idades =  new int[5];

for (int i = 0; i < quantidadeIngressos; i++)
{
    Console.WriteLine("Insira a idade:");
    int.TryParse(Console.ReadLine(), out idades[i]);
    Console.Clear();
}

var valorTotal = Bilheteria.CalcularAtendimento(quantidadeIngressos, idades);

Console.WriteLine("Valor Total: " + valorTotal);