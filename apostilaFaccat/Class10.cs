using System;

public class Exercicio014
{
	public static void Exec()
	{
		Console.WriteLine("Escreva um valor para ser comparado a 10:");
		int valor = int.Parse(Console.ReadLine());
		if( valor > 10)
		{
			Console.WriteLine("Seu numero é maior que 10!");

		}
		else
		{
			Console.WriteLine(" Seu numero  não é maior que 10!");

		}

	}
}
