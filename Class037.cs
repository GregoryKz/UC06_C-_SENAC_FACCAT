using System;

public class Exercicio037
{
	public static void Executar()
	{
		Console.WriteLine("Digite quantos kg de morango você comprou: ");
		double morango = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite quantos kg de maçã você comprou: ");
        double maca = double.Parse(Console.ReadLine());

		double valorMorango = 0;
		double valorMaca = 0;
		

		if ( morango <= 5)
		{
			 valorMorango = morango * 2.5;
		} else if (morango <= 8)
		{
			 valorMorango = morango * 2.2;
		} else if (morango > 8 || valorMorango > 25)
		{
			valorMorango = morango * 2.2;
			valorMorango = valorMorango - (valorMorango * 0.10);
		}
		if (maca <= 5)
		{
			valorMaca = maca * 1.8;
		} else if (maca <= 8)
		{
			valorMaca = maca * 1.5;
		} else if (maca > 8 || valorMaca > 25)
		{
			valorMaca = maca * 1.5;
			valorMaca = valorMaca - (valorMaca * 0.10);
		}
			Console.WriteLine($"Valor total morango: {valorMorango}");
		Console.WriteLine($"Valor total maçã: {valorMaca}");
    }
}
