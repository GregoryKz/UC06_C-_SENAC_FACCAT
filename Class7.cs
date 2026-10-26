using System;

public class Exercicio011
{
	public static void Exec()
	{
        Console.Write("Digite o total de carros vendidos: ");
        int totalCarros = int.Parse(Console.ReadLine());
		Console.Write("Digite o valor total das vendas: ");
		double totalVendas = double.Parse(Console.ReadLine());
		Console.Write("Digite o seu salario: ");
		double salario = double.Parse(Console.ReadLine());

		double comissao = (salario * 0.05) * totalCarros;
		//double valorVenda = totalVendas * 0.5;
		Console.Write($"Seu salário final é: {salario + comissao}");
	}
}
