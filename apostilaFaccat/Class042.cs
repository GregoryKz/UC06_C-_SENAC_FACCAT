using System;

public class Exercicio042
{
    public static void Executar()
    {
        Console.WriteLine("Insira o código do trabalhador:");
        int codigo = int.Parse(Console.ReadLine());
        int anoNasc = 0;
        int anoIngres = 0;
        String aposentadoria;

        if (codigo == 123)
        {
            anoNasc = 1800;
            anoIngres = 1990;
            Console.WriteLine($"{anoNasc}\n{anoIngres}\n");
        }
        else if (codigo == 321)
        {
            anoNasc = 2002;
            anoIngres = 2020;
        }



        if ((2026 - anoNasc) >= 65 || (2026 - anoIngres) >= 30)
        {
            aposentadoria = "Requerer aposentadoria.";
        }
        else if ((2026 - anoNasc) >= 60 && (2026 - anoIngres) >= 25)
        {
            aposentadoria = "Requerer aposentadoria.";
        }
        else
        {
            aposentadoria = "Não requer aposentadoria.";
        }

        Console.WriteLine($"\nO funcionário {codigo}:\n- Possui {2026 - anoNasc} anos de idade.\n- Trabalhou em TomasEntertainment por {2026 - anoIngres} anos.\n{aposentadoria}");
    }
}
