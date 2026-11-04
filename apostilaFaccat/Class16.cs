using System;

public class Exercicio020
{
    public static void Exec()
    {

        Console.WriteLine("Digite um número: ");
        int numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número (Diferente do primeiro) :");
        int numero2 = int.Parse(Console.ReadLine());

        if (numero1 < numero2)
        {
            Console.WriteLine($"{numero1}, {numero2}");
        }else if (numero1 == numero2){
            Console.WriteLine("Opção inválida!");

        }
        else { Console.WriteLine($"{numero2},{numero1}"); }
        
    } 
}