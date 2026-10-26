using System;

public class Exercicio012
{
	public static void Exec()
	{
		Console.WriteLine("Insira uma temperatura em Fahrenheit:\n");
		int tempF = int.Parse(Console.ReadLine()), tempC;

		tempC = (tempF - 32) / 9 * 5;

		Console.WriteLine($"\nA temperatura {tempF}°F em celsius será {tempC}°C");

	}
}
