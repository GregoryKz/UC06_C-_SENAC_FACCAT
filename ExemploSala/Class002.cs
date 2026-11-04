using System;

public class Exemplo002
{
    public static void Executar()
    {
        string[] filmes = { "homem miranha", "a aranha normal", "Frangoelho", "o jovem mais velho do mundo", "a velha mais nova do mundo" };
       
        foreach (string nomeF in filmes)
        {
            Console.WriteLine(nomeF);
        }
        Console.WriteLine("Fim da lista!");
    }
}
