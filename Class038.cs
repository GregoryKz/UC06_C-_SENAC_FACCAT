using System;

public class Exercicio038
{
    public static void Executar()
    {
        int senha1 = 9999;

        Console.WriteLine("Digite a senha: ");
        int senha = int.Parse(Console.ReadLine());

        int contador = 0;

        while (senha != senha1)
        {
            Console.Write("Usuario invalido! Digite sua senha novamente: ");
            senha = int.Parse(Console.ReadLine());
            contador++;

            if (senha == senha1)
            {
                Console.Write("Voce esta logado!");
            }
            
        } 
        
        
       
    }
}
