using System;

public class Exercicio017
{
	public static void Exec()
	{
		Console.WriteLine("Digite a sua primeira nota:");
		int nota1 = int.Parse(Console.ReadLine());
		Console.WriteLine(" Digite a sua segunda nota:");
		int nota2 = int.Parse(Console.ReadLine());
		int calculoMedia = (nota1 + nota2 / 2);

		if(calculoMedia >= 6)
		{
			Console.WriteLine($" Você foi aprovado(a) com a média : {calculoMedia} (;");
		}
		else
		{
			Console.WriteLine($"Você foi reprovado(a) com a média: {calculoMedia} ):");
		}
	}
}
