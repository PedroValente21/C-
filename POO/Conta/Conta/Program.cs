using System;
using System.Collections.Generic;

class Conta
{
    private DateTime _datacriacao;
    private float _saldo;
    private int _numero;
    private static int _contador;

    public Conta(float valor, DateTime data)
    {
        _numero = ++Conta._contador;
        if (valor < 0) { } else { _saldo = valor; }
        _datacriacao = data;
    }
    public DateTime DataCriacao
    {
        get { return _datacriacao; }
    }
    public float Saldo
    {
        get { return _saldo; }
    }
    public float Sacar
    {
        set { if (_saldo > value) { _saldo -= value; } }
    }
    public float Depositar
    {
        set {  _saldo += value; }
    }
    
    public int Numero 
    {
        get { return _numero; }
    }
}

class Pessoa
{
    private string _primeiroNome, _segundoNome, _endereco, _telefone;

    public Pessoa(string primeiroNome, string segundoNome, string endereco, string telefone)
    {
        PrimeiroNome = primeiroNome;
        SegundoNome = segundoNome;
        Endereco = endereco;
        Telefone = telefone;
    }

    public Pessoa()
    {
        PrimeiroNome = "Primeiro nome";
        SegundoNome = "Segundo nome";
        Endereco = "Endereco";
        Telefone = "Telefone";
    }

    public string PrimeiroNome
    {
        get { return _primeiroNome; }
        set { if (value.Length > 2) { _primeiroNome = value; } else { Console.WriteLine("Valor inválido"); } }
    }

    public string SegundoNome
    {
        get { return _segundoNome; }
        set { if (value.Length > 2) { _segundoNome = value; } else { Console.WriteLine("Valor inválido"); } }
    }

    public string Endereco
    {
        get { return _endereco; }
        set { if (value.Length > 2) { _endereco = value; } else { Console.WriteLine("Valor inválido"); } }
    }

    public string Telefone
    {
        get { return _telefone; }
        set { if (value.Length > 2) { _telefone = value; } else { Console.WriteLine("Valor inválido"); } }
    }

    public string NomeInteiro
    {
        get { return _primeiroNome + " " + _segundoNome; }
    }



    class Program
    {
        private static bool opcao(Conta x, Pessoa y)
        {

            Console.WriteLine("1- Data de criação da conta");
            Console.WriteLine("2- Sacar");
            Console.WriteLine("3- Depositar");
            Console.WriteLine("4- Ver saldo");
            Console.WriteLine("5- Ver número da conta");
            Console.WriteLine("6- Classe pessoa");
            float valor;
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("Conta criada em: " + x.DataCriacao);
                    Console.WriteLine();
                    return true;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("Valor:");
                    valor = float.Parse(Console.ReadLine());
                    x.Sacar = valor;
                    Console.WriteLine("Saldo atual: " + x.Saldo);
                    Console.WriteLine();
                    return true;
                case "3":
                    Console.WriteLine();
                    Console.WriteLine("Valor:");
                    valor = float.Parse(Console.ReadLine());
                    x.Depositar = valor;
                    Console.WriteLine("Saldo atual: " + x.Saldo);
                    Console.WriteLine();
                    return true;
                case "4":
                    Console.WriteLine();
                    Console.WriteLine("Saldo atual: " + x.Saldo);
                    Console.WriteLine();
                    return true;
                case "5":
                    Console.WriteLine();
                    Console.WriteLine("Numero da conta atual: " + x.Numero);
                    Console.WriteLine();
                    return true;
                case "6":
                    Console.WriteLine();
                    Console.WriteLine("Nome: " + y.PrimeiroNome);
                    Console.WriteLine("Segundo nome: " + y.SegundoNome);
                    Console.WriteLine("Nome completo: " + y.NomeInteiro);
                    Console.WriteLine("Endereco: " + y.Endereco);
                    Console.WriteLine("Telefone: " + y.Telefone);
                    Console.WriteLine();
                    Console.WriteLine("Digite novo nome: ");
                    y.PrimeiroNome = Console.ReadLine();
                    Console.WriteLine("Digite novo sobrenome: ");
                    y.SegundoNome = Console.ReadLine();
                    Console.WriteLine("Digite novo endereco: ");
                    y.Endereco = Console.ReadLine();
                    Console.WriteLine("Digite novo telefone: ");
                    y.Telefone = Console.ReadLine();
                    Console.WriteLine();
                    return true;

                default:
                    return false;


            }
        }

        static void Main()
        {
            Pessoa pedro = new Pessoa();
            Conta bancoInter = new Conta(1400, DateTime.Now);
            Conta bancoInter2 = new Conta(2000, DateTime.Now);
            Conta bancoInter3 = new Conta(4000, DateTime.Now);
            while (opcao(bancoInter, pedro)) ;
            while (opcao(bancoInter2, pedro)) ;
            while (opcao(bancoInter3, pedro)) ;
        }
    }
}

    
