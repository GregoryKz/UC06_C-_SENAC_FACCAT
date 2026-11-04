using System;

public class Class1
{
    public class Produto
    {
        
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
    }
    public static void Executar()
    {
        Console.WriteLine("teste");
    }


}
