using System;
using System.Net;
using System.Security.Principal;

public class Produto 
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public decimal Preco { get; set; }
    public int Estoque { get; set; }
    public Produto(int id, string nome, decimal preco, int estoque)
    { 
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("Nome é obrigatório.");
		if (preco< 0)
			throw new ArgumentException("Preço inválido.");


        Id = id;
        Nome = nome;
        Preco = preco;
        Estoque = estoque;

		
	}




}
