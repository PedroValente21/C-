using System;
using System.Collections.Generic;

class Produto
{
    private string descricao;
    private int quantidade;
    private double preco;

    public Produto (string descricao, int quantidade, double preco)
    {
        this.descricao = descricao;
        this.quantidade = quantidade;
        this.preco = preco;
    }

    public Produto()
    {
        this.descricao = "Criado default";
        this.quantidade = 10;
        this.preco = 9.99;
    }

    public string Desricao
    {
        get { return this.descricao; }
    }

    public int Quantidade
    {
        get { return this.quantidade; }
    }

    public double Preco
    {
        get { return this.preco; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Produto produto1 = new Produto();
        Produto produto2 = new Produto("Kyrie Eleison", 10000, 100);

        Console.WriteLine("Produto criado com construtor padrão:\n{0}\n{1}\n{2}\n", 
            produto1.Desricao, produto1.Quantidade, produto1.Preco);

        Console.WriteLine("Produto criado com construtor especifico:\n{0}\n{1}\n{2}",
            produto2.Desricao, produto2.Quantidade, produto2.Preco);

    }
}