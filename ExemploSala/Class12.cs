using System;

public class ExercicioMetodo003
{
	public static void Executar()

	{
		static double Somar(double somaA, double somaB)
		{
			return somaA + somaB;
		}
		static void Saudar(string nome)
		{
			Console.WriteLine($"Olá, {nome}!");




		}
		double resultado = Somar(3, 4.5);
		Saudar("Ana");
		Console.WriteLine(resultado);
	}
}
