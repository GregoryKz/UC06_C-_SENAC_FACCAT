using System;

public class Carro
{

    public string Marca { get; set; }

    public string Modelo { get; set; }

    public int Ano { get; set; }

    public string Categoria { get; set; }

    public decimal Quilometragem { get; private set; }

    public int QuantiaPessoas { get; set; }

    public decimal ValorDiaria { get; set; }

    public bool Disponibilidade { get; set; }

    public string Combustivel { get; set; }

    public decimal LimiteKM { get; set; }

    public string Cambio { get; set; }
   
    


    public Carro (string marca, string modelo, int ano, string categoria, decimal quilometragem, int quantiaPessoa, decimal valorDiaria, string combustivel, decimal LimiteKm, string cambio)
    {
        if (string.IsNullOrWhiteSpace(marca))
            throw new ArgumentException("Marca nao pode estar nulo");
        if (ano < 2016)
            throw new ArgumentException("Fale um ano que tenha um carro existente");
        if (string.IsNullOrWhiteSpace(modelo))
            throw new ArgumentException("O modelo nao pode estar nulo");
        if (string.IsNullOrWhiteSpace(categoria))
            throw new ArgumentException("A categoria nao pode ser nula");
        if (quilometragem == null)
            throw new ArgumentException("A quilometragem nao pode ser nula");
        if (quantiaPessoa < 2 || quantiaPessoa >= 8)
            throw new ArgumentException("Nao podemos registrar um carro com essa quantia de lugares");
        if (valorDiaria == null || valorDiaria < 0)
            throw new ArgumentException("Nao podemos registrar um carro com esse valor");
        if (combustivel != "Gasolina" && combustivel != "Flex" && combustivel != "Hibrido" && combustivel != "Eletrico")
            throw new ArgumentException("Não existe carro com esse tipo de combustivel");
        if (LimiteKm == null)
            throw new ArgumentException("Insira um limite de Km");
        if (cambio != "Manual" && cambio != "Automatico")
            throw new ArgumentException("Adicione um carro com cambio valido");
               


        Marca = marca;
        Ano = ano;
        Modelo = modelo;
        Categoria = categoria;
        Quilometragem = quilometragem;
        QuantiaPessoas = quantiaPessoa;
        ValorDiaria = valorDiaria;
        Combustivel = combustivel;
        LimiteKM = LimiteKm;
        Cambio = cambio;
        Disponibilidade = true;


    }
    public void Mostrar()
    {
        Console.WriteLine($"\n{Marca} - {Ano} - {Modelo} - {Categoria} - {Quilometragem} - {QuantiaPessoas} - {ValorDiaria} - {Combustivel} - {LimiteKM} - {Cambio} - {Disponibilidade}");
    }

    public int Velocidade { get; private set; }

    public void Acelerar (int valor)
    {
        Quilometragem += valor;
    }

    public void Frear (int valor)
    {
        Quilometragem -= valor;
        if (Quilometragem < 0)
        {
            Quilometragem = 0;
        }
    }
}
