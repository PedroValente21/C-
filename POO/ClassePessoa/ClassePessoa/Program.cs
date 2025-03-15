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

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa("Pedro", "Rua Jacutinga", "31997944389");
        Pessoa pessoa1 = new Pessoa();
        Console.WriteLine(pessoa.primeiroNome());
        Console.WriteLine(pessoa1.primeiroNome());

    }
}
