using System;

public class Exemplo003
{
	public static void Executar()
	{
		double[] notas = { 6.0, 8.5, 3.0 };
		double maior = notas[0],menor = notas[0], soma = 0;

		for (int contador = 0; contador < notas.Length; contador++)
		{
			soma += notas[contador];
			if (notas[contador] > maior)
			{
				maior = notas[contador];
			}
			if (notas[contador] < menor)
			{
				menor = notas[contador];
			}
		}
		Console.WriteLine($"Sua média de foi: {soma/3}");
		Console.WriteLine($"Sua maior nota foi: {maior}");
		Console.WriteLine($"Sua menor nota foi: {menor}");

	}
}
