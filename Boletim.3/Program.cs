using System;

namespace Boletim
{
    internal class Bolet
    {
      static void Main(string[] args)
        {
            Console.WriteLine("insira uma nota");
            int Nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a segunda nota");
            int Nota2 = int.Parse(Console.ReadLine()),
                MediaNotas = (Nota1 + Nota2) / 2;

            if (MediaNotas >= 7)
            {
                Console.WriteLine("aprovado");

            }
            else if (MediaNotas >= 5)
            {
                Console.WriteLine("Recuperacao");
            }
            else {

                Console.WriteLine("Reprovado");
            }
        }
    }
}
