using System;
public class Exemplo004v1
{
    public static void Executar()
    {
        int[] numero = { 1, 2, 3, 4, 5, 67, 8, 9, 10 };

        for (int indice = numero.Length-1; indice > -1; indice--)
        {
            
            Console.Write($"\n{numero[indice]}");
        }
    }
}
