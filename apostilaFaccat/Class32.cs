using System;

public class exercicio032
{
    public static void Executar()
    {
        Console.Write("Escreva o nome do time: ");
        string nome = Console.ReadLine();

        Console.Write("Escreva o nome do outro time: ");
        string nome2 = Console.ReadLine();

        Console.Write("Digite o numero de gols marcados para o time 1: ");
        int gols1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o numero de gols marcados para o time 2: ");
        int gols2 = int.Parse(Console.ReadLine());


        if (gols1 > gols2)
        {
            Console.WriteLine($"Time {nome} Vencedor!");
        } else if (gols1 == gols2)
        {
            Console.WriteLine("Empate");
        } else
        {
            Console.WriteLine($"Time {nome2} vencedor! ");
        }


    }
}
