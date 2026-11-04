using System;
using System.Runtime.Serialization;

public class Exemplo004v4
{
	public static void Executar()
	{
		double media = 0;
		double[] aluno = {0,0,0,0,0,0};

		for(int contador = 0; contador<7;contador++){

			Console.WriteLine($"Digite a nota do {contador+1}° aluno.");
			aluno[contador]=double.Parse(Console.ReadLine()); //Errado
			
            media += contador / 6;

        }
		Console.WriteLine($"\nMédia total: {media}");


		Console.WriteLine($"\nNotas acima da média:");

        foreach (int A in aluno)
		{
			if(A > media)
			{
				Console.WriteLine(A);
			}
		} 	
	}
}
