using System;

public class Exercicio019
{
    public static void Exec()
    {
        Console.Write("Digite um numero: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Digite um numero (Diferente do primeiro numero): ");
        int numero2 = int.Parse(Console.ReadLine());

        if (numero > numero2)
        {
            Console.WriteLine("O numero 1 é maior que o numero 2");
        } else
        {
            Console.WriteLine("O numero 2 é maior que o numero 1");
        }
    }
}
