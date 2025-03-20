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

class Comida : Produto
{
    private DateTime _validade;

    public Comida()
    {
        this._validade = DateTime.Now;
    }
    public Comida(string descricao, int quantidade, double preco, DateTime validade) : base (descricao, quantidade, preco)
    {
        this._validade = validade;
    }
    public DateTime Validade
    {
        get { return _validade; }
        set { _validade = value; }
    }

    public DateTime GetValidade()
    {
        return this._validade;
    }

    public void SetValidade(int value)
    {
        int dias = value;
        this._validade = _validade.AddDays(dias);
    }

}

class Eletronico : Produto
{
    private DateTime _garantia;
    public Eletronico()
    {
        this._garantia = DateTime.Now;
    }
    public Eletronico(string descricao, int quantidade, double preco, DateTime garantia) : base(descricao, quantidade, preco)
    {
        this._garantia= garantia;
    }
    public DateTime GetGarantia()
    {
        return this._garantia;
    }

    public void SetGarantia(int value)
    {
        int dias = value; 
        this._garantia = _garantia.AddDays(dias); 
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Produto produto1 = new Produto();
        Comida arroz = new Comida("1 kg", 1, 15.99, DateTime.Now);
        Eletronico celular = new Eletronico();
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
        Console.WriteLine();

        Console.WriteLine("Comida:\n{0}\n{1}\n{2}\n{3}\n{4}",
            arroz.Descricao, arroz.Quantidade, arroz.Preco, arroz.Id, arroz.GetValidade());
        Console.WriteLine();

        Console.WriteLine("Eletronico:\n{0}\n{1}\n{2}\n{3}\n{4}",
            celular.Descricao, celular.Quantidade, celular.Preco, celular.Id, celular.GetGarantia());
        Console.WriteLine();

        Console.WriteLine("Insira os dias até o vencimento: ");
        int vencimento = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira os dias de garantia: ");
        int garantia = int.Parse(Console.ReadLine());
        arroz.SetValidade(vencimento);
        celular.SetGarantia(garantia);

        Console.WriteLine("Nova data de validade comida:\n{0}",
            arroz.GetValidade());
        Console.WriteLine();

        Console.WriteLine("Nova garantia  eletronico:\n{0}",
            celular.GetGarantia());
        Console.WriteLine();

    }
}