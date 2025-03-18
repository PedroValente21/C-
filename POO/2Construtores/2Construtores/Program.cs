using System;
using System.Collections.Generic;

class Produto
{
    private string descricao;
    private int quantidade, id;
    private double preco;

    public static int contador;

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

    public int GetId()
    {
        return id;
    }

    public double GetPreco()
    {
        return preco;
    }

    public void SetPreco(double valor)
    {
        if (valor > 0)
        {
            preco = valor;
            Console.WriteLine("");
        } else
        {
            Console.WriteLine("Valor inválido");
            Console.WriteLine("");
        }
    }

    public string GetDescricao()
    {
        return descricao;
    }

    public void SetDescricao(string info)
    {
        descricao = info;
    }

    public int GetQuantidade()
    {
        return quantidade;
    }

    public void SetQuantidade(int valor)
    {
        if (valor > 0)
        {
            quantidade = valor;
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Valor inválido");
            Console.WriteLine("");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Produto produto1 = new Produto();
        Produto produto2 = new Produto("Kyrie Eleison", 10000, 100);

        Console.WriteLine("Produto criado com construtor padrão:\n{0}\n{1}\n{2}\n{3}", 
            produto1.GetDescricao(), produto1.GetQuantidade(), produto1.GetPreco(), produto1.GetId());
        Console.WriteLine("");

        Console.WriteLine("Produto criado com construtor especifico:\n{0}\n{1}\n{2}\n{3}",
            produto2.GetDescricao(), produto2.GetQuantidade(), produto2.GetPreco(), produto2.GetId());
        Console.WriteLine("");

    }
}