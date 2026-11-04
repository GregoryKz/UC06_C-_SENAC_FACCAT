using System;

public class Exercicio008

{
	public static void Executar()
	{
		Console.WriteLine("Escreva o numero de eleitores do seu municipio:");
		int eleitores = int.Parse(Console.ReadLine());
		Console.WriteLine("Escreva a quantidade de votos brancos:");
		int brancos = int.Parse(Console.ReadLine());
		Console.WriteLine("Escreva a quantidade de votos nulos:");
		int nulos = int.Parse(Console.ReadLine());
		Console.WriteLine("Escreva a quantidade de votos validos:");
		int validos = int.Parse(Console.ReadLine());

		
		Console.WriteLine($"Porcentagem de votos brancos {(double)eleitores / brancos * 100:F2}%");
		Console.WriteLine($"Porcentagem de votos nulos {(double)eleitores / nulos * 100:F2}%");
		Console.WriteLine($"Porcentagem de votos validos {(double)eleitores / validos * 100:F2}%");
            

    }
}
