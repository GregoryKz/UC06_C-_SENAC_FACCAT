using System;

public class ExercicioMatriz001
{
	public static void Executar()
	{
		int[,] m = {
			{1,3,5 },
			{3,6,8 },
			{5,8,9 }

		};
		for (int l = 0; l < m.GetLength(0); l++)
		{
			for (int c = 0; c < m.GetLength(1); c++)
			{
				Console.Write(m[l, c] + "\t");
			}
			Console.WriteLine();
		}
	}
}
