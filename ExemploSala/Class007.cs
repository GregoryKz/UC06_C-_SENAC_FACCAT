using System;

public class Exemplo005
{
	public static void Executar()
	{
		int[,] m =
		{
			{7,8,6,9 },
			{5,6,7,8 },
			{9,9,8,10}

		};

		for (int l = 0; l < m.GetLength(0); l++)
		{
			for (int c = 0; c < m.GetLength(1); c++)
			{
				Console.Write(m[l, c]+"\t");
			} 
			Console.WriteLine();
		}       


	}
}
