using System;

public class Exercicio041
{
    public static void Executar()
    {
        Console.WriteLine("Digite a nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota: ");
        double nota3 = double.Parse(Console.ReadLine());

      

        double media = (nota1 + nota2  + nota3)  / 3;
        double mediaAproveitamento = ((nota1 + (nota2 * 2) + (nota3 * 3)) + media) / 7;

        if (mediaAproveitamento < 6)
        {
            Console.WriteLine("D");
        }else if (mediaAproveitamento < 7.5)
        {
            Console.WriteLine("C");
        }else if (mediaAproveitamento < 9)
        {
            Console.Write("B");
        } else if (mediaAproveitamento >= 9)
        {
            Console.Write("A");
        }



        
    }
}
