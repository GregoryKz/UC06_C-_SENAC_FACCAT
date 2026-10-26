using System;

public class Exercicio006
{
	public static void Executar()
	{
		Console.WriteLine("Digite o numero da base:");
			int basee = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o numero da altura:");
			int altura = int.Parse(Console.ReadLine());
		double calculo = (basee * altura);
		Console.WriteLine($"Sua area do retangulo é {calculo}");
	}
}
