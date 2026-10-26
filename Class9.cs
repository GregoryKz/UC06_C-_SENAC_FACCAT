using System;

public class Exercicio013
{
	public static void Exec()
	{
		Console.WriteLine(" Digite a sua nota:");
		double nota1 = double.Parse( Console.ReadLine());
		Console.WriteLine("Digite a sua segunda nota:");
		double nota2 = double.Parse(Console.ReadLine());
		Console.WriteLine("Digite a sua terceira nota:");
		double nota3 = double.Parse(Console.ReadLine());

		double mediaFinal = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5) )/ 10;
		Console.WriteLine($"Sua media é {mediaFinal} (:");
	}
}
