using System;

public class Exemplo004v6
{
	public static void Executar()
	{
		double[] numeroA = {1.0,2.0,3.0,4.0,5.0};
		double[] numeroB = {0,0,0,0,0};
		int contador = 0;

		foreach (int A in numeroA)
		{
			numeroB[contador] = A*2;
			Console.WriteLine($"O dobro de {A} numero é: {numeroB[contador]}");
			contador++;
		}
	}
}
