using System;

public class Exercicio035
{
	public static void Executar()
	{
		Console.WriteLine("Digite a quantidade de litros do alcool: ");
		int A = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de litros da gasolina: ");
        int G = int.Parse(Console.ReadLine());
		double alcool = 4.40;
		double gasolina = 6.40;

		if(A < 20)
		{
			Console.WriteLine($"Valor a ser pago do alcool pelo cliente: {A * alcool * 0.95}:F2");

		}
		else 
		{
			Console.WriteLine($"Valor a ser pago do alcool pelo cliente: {(A * alcool) * 0.95}:F2");
		}
		if (G < 20)
		{
			Console.WriteLine($"Valor a ser pago da gasolina pelo cliente: {(G * gasolina) * 0.95}:F2");
		}
		else
		{
			Console.WriteLine($"Valor a ser pago da gasolina pelo cliente: {(G * gasolina) * 0.95}:F2");
		}

	}
}
