using System;

public class Exercicio022
{
	public static void exec()
	{
		Console.WriteLine("Informe o número de horas trabalhadas: ");
		int hora = int.Parse(Console.ReadLine());
		Console.WriteLine("Informe o valor do salario por hora: ");
		int salario = int.Parse(Console.ReadLine());


		double horasRegulares = 160;
		double salarioTotal = salario * hora;
		double extra = (hora-160) * salario * 0.5;

		if(hora == horasRegulares)
		{
			Console.WriteLine($"Salario: {salarioTotal}");
		}
		else { Console.WriteLine($"Salario com horas extras: {salarioTotal + extra}"); }
	}
}
