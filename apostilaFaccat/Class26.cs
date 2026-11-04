using System;

public class Exercicio026
{
	public static void Executar()
	{
		Console.WriteLine("Digite a quantidade atual do estoque: ");
		int atual = int.Parse(Console.ReadLine());

		Console.WriteLine("Digite a capacidade maxima do estoque: ");
		int maxima = int.Parse(Console.ReadLine());

		Console.WriteLine("Digite a quantidade minima do estoque: ");
		int minima = int.Parse(Console.ReadLine());

		double Media = maxima + minima / 2;

		if (atual >= Media)
		{
			Console.WriteLine("Não efetuar compra");
		}
		else
		{
			Console.WriteLine("Efetuar compra ");
		}
	}
}
