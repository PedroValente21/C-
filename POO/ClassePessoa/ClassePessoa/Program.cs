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
        Console.WriteLine(pessoa.primeiroNome());
    }
}
