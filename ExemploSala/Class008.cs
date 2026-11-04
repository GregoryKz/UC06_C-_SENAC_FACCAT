using System;

public class Exemplo006
{
	public static void Executar()
	{
		string[] alunos = { "Ana", "Bia", "Caio" };
		double[,] notas =
		{
			{7,8,6,9},
			{5,6,7,8},
			{9,9,8,10}
		};
		for (int l = 0; l < notas.GetLength(0); l++)
		{
			double soma = 0;
			for (int c = 0; c < notas.GetLength(1); c++)
			{
				soma += notas[l, c];
			}
			double media = soma / notas.GetLength(1);
			Console.WriteLine($"{alunos[l]}: {media}");
		}
	}
}
