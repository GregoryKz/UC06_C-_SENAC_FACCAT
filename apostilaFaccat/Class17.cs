using System;

public class Exercicio021
{
	public static void exec()
	{
		Console.Write("Digite a hora do inicio do jogo: ");
		int inicio = int.Parse(Console.ReadLine());

		Console.Write("Digite a hora do fim do jogo: ");
		int fim = int.Parse(Console.ReadLine());

		

		int horas = fim - inicio;

		if (horas <= 0)
		{
			horas += 24;
			
		}
        Console.WriteLine("O jogo durou: " + horas);
    }
}
