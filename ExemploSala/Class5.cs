using System;
using System.Net.Mime;
using System.Runtime.InteropServices;

public class ExercicioMetodo005
{
    public static void Executar()
    {
        static string Situacao (int media)
        {
            if(media >= 7)
            {
                return "Aprovado!";
             
            } else if(media < 7 || media >= 5)
            {
                return "Recuperação!";
                
            } else
            {
                return"Reprovado!";
            }
        }

        string aluno1 = Situacao(6);
        Console.WriteLine(aluno1);
    }


}
