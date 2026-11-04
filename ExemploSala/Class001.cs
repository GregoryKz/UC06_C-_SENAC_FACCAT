using System;

public class Exemplo001
{
	public static void Executar()
	{
		string[] nomes = { "Felipe", "Danilo", "gustavo", "cauã", "tomas", "Geovana", "lorrany", "allex gamer", "davi", "carol", "gregory" };

		for (int contador = 0; contador < nomes.Length; contador++)
		{
			Console.WriteLine(nomes[contador]);
		}
	}
}
