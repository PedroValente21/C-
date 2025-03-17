using System;
using System.Collections.Generic;

class Produto
{
    private string descricao;
    private int quantidade, id;
    private double preco;

    private static int contador;

    public Produto (string descricao, int quantidade, double preco)
    {
        this.id = ++Produto.contador;

        this.descricao = descricao;
        this.quantidade = quantidade;
        this.preco = preco;
    }

    public Produto()
    {
        this.id = ++Produto.contador;

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

    public int Id
    {
        get { return this.id; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Produto produto1 = new Produto();
        Produto produto2 = new Produto("Kyrie Eleison", 10000, 100);

        Console.WriteLine("Produto criado com construtor padrão:\n{0}\n{1}\n{2}\n{3}", 
            produto1.Desricao, produto1.Quantidade, produto1.Preco, produto1.Id);

        Console.WriteLine("Produto criado com construtor especifico:\n{0}\n{1}\n{2}\n{3}",
            produto2.Desricao, produto2.Quantidade, produto2.Preco, produto2.Id);

    }
}