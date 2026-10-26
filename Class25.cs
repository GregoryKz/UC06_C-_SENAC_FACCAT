using System;

public class Exercicio025

{
    public static void Executar()
    {
        Console.Write("Digite o numero da conta do cliente: \n");
        int conta = int.Parse(Console.ReadLine());
        
        Console.WriteLine("\nDigite o saldo atual: \n");
        int saldo = int.Parse(Console.ReadLine());
        
        Console.WriteLine("\nDigite o credito disponivel: \n");
        int credito = int.Parse(Console.ReadLine());
        
        Console.WriteLine("\nDigite o debito da conta: \n");
        int debito = int.Parse(Console.ReadLine());

        int saldoAtual = saldo + credito - debito;

        if (saldoAtual > 0)
        {
            Console.WriteLine($"\nSaldo da conta {conta} esta Positivo.");
        }
        else
        {
            Console.WriteLine($"\nSaldo da conta {conta} esta Negativo.");
        }
    }
}
