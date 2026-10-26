using System;

public class Exercicio028
{
	public static void Executar()
	{
		Console.WriteLine("Digite um numero!");
		int numero1 = int.Parse(Console.ReadLine());

		Console.WriteLine("Digite um numero diferente do primeiro numero: ");
		int numero2 = int.Parse(Console.ReadLine());

		Console.WriteLine("Digite um numero diferente do segundo numero: ");
		int numero3 = int.Parse(Console.ReadLine());

		if (numero1 > numero2 && numero1 > numero3)
		{
			Console.WriteLine($"O numero maior é {numero1}");
		}
		else if (numero2 > numero1 && numero2 > numero3) 
		{
			Console.WriteLine($"O numero maior é {numero2}");
		} 
		else
		{
			Console.WriteLine($"O numero maior é {numero3}");
		}
	}
}
