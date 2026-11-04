using System;

public class Exercicio029
{
	public static void Executar()
	{
        Console.WriteLine("Digite um numero!");

        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um numero diferente do primeiro numero: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um numero diferente do segundo numero: ");
        int numero3 = int.Parse(Console.ReadLine());

        if (numero1 > numero2 && numero3 > numero2)
        {
            Console.WriteLine($"As somas dos numeros maiores são: {numero1 + numero3}");
        }else if (numero1 > numero3 && numero2 > numero3)
        {
            Console.WriteLine($"As somas dos numeros maiores são: {numero1 + numero2}");
        } else if (numero2 > numero1 && numero3 > numero1)
        {
            Console.WriteLine($"As somas dos numeros maiores são: {numero2 + numero3}");
        }

    }
}
