using System;

public class Exercicio027
{
	public static void Executar()
	{
		Console.WriteLine("Digite um numero");
		int numero = int.Parse(Console.ReadLine());

		if (numero > 0)
		{
			Console.WriteLine("Seu numero é positivo");
		}else if(numero < 0)
		{
			Console.WriteLine("Seu numero é negativo");
		}
		else
		{
			Console.WriteLine("Seu numero é 0! ");
		}
	}
}
