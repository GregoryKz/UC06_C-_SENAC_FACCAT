using System;
using System.Dynamic;
using System.Runtime.Serialization;

public class ExercicioMatriz002
{
	public static void  Executar()
	{
		int[,] m =
		{
			{2,4,6,8},
			{3,6,9,12}

		};
		for(int l = 0; l < m.GetLength(0); l++)
		{
			int soma = 0;

			for (int c = 0; c < m.GetLength(1); c++)
			{
				soma += m[l, c];

				Console.Write(soma);
			}
			Console.WriteLine();
		}



	}
}
