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
   
        Descricao = descricao;
        Quantidade = quantidade;
        Preco = preco;
    }

    public Produto()
    {
        this.id = ++Produto.contador;

        Descricao = "Criado default";
        Quantidade = 10;
        Preco = 9.99;
    }

    public int Id { get { return id; } }

    public double Preco
    {
        get { return preco; }
        set { if (value > 0) { preco = value; } else { Console.WriteLine("Valor inválido"); } }
    }

    public string Descricao
    {
        get { return descricao; }
        set { if (value.Length > 3) { descricao = value; } else { Console.WriteLine("Descrição muito curta"); } }
    }

    public int Quantidade
    {
        get { return quantidade; }
        set { if (value > 0) { quantidade = value; } else { Console.WriteLine("Quantidade inválida"); } }
    }
 }

class Program
{
    static void Main(string[] args)
    {
        
        Produto produto1 = new Produto();
        Produto produto2 = new Produto("Kyrie Eleison", 10000, 100);

        Console.WriteLine("Produto criado com construtor padrão:\n{0}\n{1}\n{2}\n{3}", 
            produto1.Descricao, produto1.Quantidade, produto1.Preco, produto1.Id);
        Console.WriteLine("");

        Console.WriteLine("Produto criado com construtor especifico:\n{0}\n{1}\n{2}\n{3}",
            produto2.Descricao, produto2.Quantidade, produto2.Preco, produto2.Id);
        Console.WriteLine("");

        Console.WriteLine("Insira novo preço para o produto 2: ");
        double valor = double.Parse(Console.ReadLine());
        produto2.Preco = valor;

        Console.WriteLine("Produto 2:\n{0}\n{1}\n{2}\n{3}",
           produto2.Descricao, produto2.Quantidade, produto2.Preco, produto2.Id);

    }
}