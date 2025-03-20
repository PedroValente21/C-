using System;
using System.Collections.Generic;

class Pessoa
{
    public string _nome, _endereco, _telefone;

    public Pessoa(string nome, string endereco, string telefone)
    {
        _nome = nome;
        _endereco = endereco;
        _telefone = telefone;
    }

    public Pessoa()
    {
        _nome = "Nome não descrito";
        _endereco = "Endereço não descrito";
        _telefone = "Telefone não descrito";
    }
    public string primeiroNome()
    {
        return _nome;
    }
}

class Fisica : Pessoa
{
    private string cpf;

    public Fisica()
    {
        this.cpf = "000.000.000.00";
    }

    public string CPF
    {
        get { return this.cpf; }
        set { this.cpf = value; }
    }
}

class Juridica : Pessoa
{
    private string cnpj;
    public Juridica()
    {
        this.cnpj = "00.000.000/0000-00";
    }
    public string CNPJ
    {
        get { return this.cnpj; }
        set { this.cnpj = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa("Pedro", "Rua Jacutinga", "31997944389");
        Pessoa pessoa1 = new Pessoa();
        Fisica fisica = new Fisica();
        Juridica juridica = new Juridica();
        Console.WriteLine(pessoa.primeiroNome());
        Console.WriteLine(pessoa1.primeiroNome());
        Console.WriteLine("{0} - {1}",fisica.primeiroNome(), fisica.CPF);
        Console.WriteLine("{0} - {1}",juridica.primeiroNome(), juridica.CNPJ);
        Console.WriteLine();
        Console.WriteLine("Digite o CPF da pessoa: ");
        fisica.CPF = Console.ReadLine();
        Console.WriteLine("{0} - {1}", fisica.primeiroNome(), fisica.CPF);
    }
}
