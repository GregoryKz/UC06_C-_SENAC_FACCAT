using System;
using System.Configuration;

public class Exercicio036
{
	public static void Executar()
	{
		Console.WriteLine("Digite sua idade(H): ");
		int idade1M = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua idade(H): ");
        int idade2M = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua idade(M): ");
        int idade1F = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua idade(M): ");
        int idade2F = int.Parse(Console.ReadLine());


        int velhoM = 0;
        int novoM = 0;

        int velhaF = 0;
        int novaF = 0;

        if (idade1M != idade2M)
        {
            if (idade1M > idade2M)
            {
                velhoM = idade1M;
                novoM = idade2M;
            } else
            {
                velhoM = idade2M;
                novoM = idade1M;
            }
        }
        if (idade1F != idade2F)
        {
            if (idade1F < idade2F)
            {
                novaF = idade1F;
                velhaF = idade2F;
            } else
            {
                 novaF = idade2F;
                 velhaF = idade1F;

            }
        }
        int calculo1 = novaF + velhoM;
        int calculo2 = velhaF + novoM;

        Console.WriteLine($" Mulher mais nova + homem mais velho: {calculo1}");
        Console.WriteLine($"Mulher mais velha + homem mais novo: {calculo2}");

    }
}
