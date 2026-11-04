using System;

public class Exercicio031
{
	public static void Executar()
	{
		Console.Write("Digite o valor A: ");
		int valor = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor B: ");
        int valor2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor C: ");
        int valor3 = int.Parse(Console.ReadLine());

    



       if (valor < valor2 + valor3 && valor2 < valor3 + valor && valor3 < valor2 + valor)
        {
            Console.WriteLine("é triangulo");
        } else
        {
            Console.WriteLine("Nao é triangulo");
        }



    }
}
