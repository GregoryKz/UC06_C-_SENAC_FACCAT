using System;

public class Exercicio010
{
	public static void Executar()
	{
	Console.WriteLine("Digite o custo da fabrica: ");
		double fabrica = double.Parse(Console.ReadLine());
	    double impostos = (1.73);
	Console.WriteLine($"O custo do carro é: {fabrica * impostos:F2}");
	}
}
