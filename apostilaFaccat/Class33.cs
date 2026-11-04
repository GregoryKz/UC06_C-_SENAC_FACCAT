using System;

public class Exercicio033
{
	public static void Executar()
	{
		Console.Write("Digite um numero: ");
		int numero = int.Parse(Console.ReadLine());

        Console.Write("Digite um numero: ");
        int numero2 = int.Parse(Console.ReadLine());

		if (numero == numero2 || numero2 == numero )
		{
			Console.WriteLine("Numeros iguais");
		} else if (numero > numero2 )
		{
			Console.WriteLine("Numero 1 maior que o segundo");
		}
        else if (numero2 > numero)
        {
			Console.WriteLine("Numero 2 maior que o primeiro");

        }



    }
}
