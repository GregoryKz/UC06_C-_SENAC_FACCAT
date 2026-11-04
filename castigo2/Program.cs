using System;

namespace Exemplo2
{
    internal class Exemplo2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a idade: ");
            int idade = int.Parse(Console.ReadLine());

            if(idade >= 18)
            {
                Console.WriteLine("Você é obrigado a votar!");
            }else if(idade >= 16)
            {
                Console.WriteLine("Seu voto é opcional");
            }
            else
            {
                Console.WriteLine("Você ainda não vota!");
            }
        }
    }
}