using System;

public class Exercicio015
{
	public static void Exec()
	{
		Console.WriteLine(" Digite um valor:");
		int valor = int.Parse(Console.ReadLine());
		if (valor >= 0)
		{
			Console.WriteLine(" Seu número é positivo");

		}
		else
		{
			Console.WriteLine(" Seu numero é negativo!");
		}


	}
}
