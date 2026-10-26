using System;

public class Exercicio007
{
	public static void Executar()
	{
		Console.WriteLine("Digite sua idade:");
		int idade = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o mes:");
		int mes = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o dia:");
		int dia = int.Parse(Console.ReadLine());

		Console.WriteLine($"Você tem {(idade * 365) + (mes * 30) + dia} dias de vida");
	}
}
