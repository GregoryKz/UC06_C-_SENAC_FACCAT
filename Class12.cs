using System;

public class Exercicio016
{
	public static void Exec()
	{
		Console.WriteLine("Digite a quantidade de maça comprada:");
		int quantidade = int.Parse(Console.ReadLine());
		double meiaduzia = 1.30;
		double duzia = 1.00;
		
			if(quantidade < 12)
		    {
			Console.WriteLine($" sua compra fica R$ {meiaduzia * quantidade} ");		
		    }

		else {
			Console.WriteLine($"sua compra fica R$ {duzia * quantidade}");
		
		}
	}
}
