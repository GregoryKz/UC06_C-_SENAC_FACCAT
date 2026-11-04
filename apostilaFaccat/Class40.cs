using System;

public class Exercicio040
{
    public static void Executar()
    {
        Console.WriteLine("Digite o nome do produto: ");
        string produto = Console.ReadLine();

        Console.WriteLine("Digite o quantidade adquirida do produto: ");
        int quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do produto: ");
        double valor = double.Parse(Console.ReadLine());

        double total = quantidade * valor;
        double totalF = 0;
        double porcento = 0;

         if ( quantidade <= 5)
        {
            totalF = total - (total * 0.02);
            porcento = 2;
        }else if ( quantidade <= 10)
        {
            totalF = total - (total * 0.03);
            porcento = 3;
        }
        else if (quantidade > 10)
        {
            totalF = total - (total * 0.05);
            porcento = 5;
        }
        Console.WriteLine($"Total da compra: R${total} ---- porcentagem de desconto: {porcento}% ---- Valor a pagar: R${totalF}");
    }
}
