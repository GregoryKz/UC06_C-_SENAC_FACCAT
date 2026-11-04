using System;
namespace Calculadora
{
    internal class Exemplo9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero 1: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Operação ( + - * /):");
            string op = Console.ReadLine();

            Console.WriteLine("Numero 2: ");
            double b = double.Parse(Console.ReadLine());

            switch (op)
            {
                case "+": 
                    Console.WriteLine($"Resultado: {a + b}"); 
                    break;
                case "-":
                    Console.WriteLine($"Resultado: {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"Resultado: {a * b}");
                    break;
                case "/":
                    if (b == 0) { 
                        Console.WriteLine("Não da para dividir por 0!");
                    }
                    else { 
                        Console.WriteLine($"Resultado: {a / b}");
                    }
                    break;
                default: 
                    Console.WriteLine("Operação invalida!"); 
                    break;
            }
        }
    }
}

