using System;
using System.Runtime.InteropServices;

public class Exercicio024
{
    public static void Executar()
    {
        Console.Write("Digite o salario:");
        double salario = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor total das vendas: ");
        double vendas = double.Parse(Console.ReadLine());

        double comissao = 0.03;
        double comissao2 = 0.05;

        if (vendas <= 1500)
        {
            vendas = vendas * comissao;
            Console.Write($"Sua comissão e de: {comissao * 100}%, Salario total: {vendas + salario}");
        }
        else if (vendas > 1500)
        {
            vendas = vendas * (comissao + comissao2);
            Console.Write($"Sua comissão é de: {(comissao + comissao2) * 100}%, Salario total: {vendas + salario}");
        }

    }
}
