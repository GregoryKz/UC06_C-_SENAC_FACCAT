using System;

public class Exercicio018
{
    public static void Exec()
    {
        Console.WriteLine("Informe o ano de nascimento: ");
        int anoNascimento = int.Parse(Console.ReadLine());

        int anoAtual = 2026;

        int idade = anoAtual - anoNascimento;

        if (idade >= 18)
        {
            Console.WriteLine("Já pode votar");
        }
        else if (idade >= 16)
        {
            Console.WriteLine("Já pode votar, porém não é obrigatório");
        }
        else { Console.WriteLine("Não pode votar"); }
    }
}
