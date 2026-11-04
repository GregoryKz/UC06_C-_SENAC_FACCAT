using System;

namespace Exemplo3
{
    internal class Exemplo3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine("Número é par");

            }
            else
            {
                Console.WriteLine("Número é ímpar");
            }
        }
    }
}
