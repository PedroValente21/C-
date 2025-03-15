using System;
using System.Collections.Generic;

class Conta
{
    private DateTime _datacriacao;
    private float _saldo = 0;

    public Conta(float valor, DateTime data)
    {
        _saldo = valor;
        _datacriacao = data;
    }
    public DateTime DataCriacao
    {
        get { return _datacriacao; }
    }
    public float Sacar (float valor)
    {
        if (_saldo < valor)
        {
            throw new ArgumentException("Quantia de saque não permitida.", "quantia");
        }
        
        _saldo -= valor;

        return _saldo;
    }
    public float Depositar(float valor)
    {
        _saldo += valor;

        return _saldo;
    }
    public float Saldo
    {
        get { return _saldo; }
    }
}

class Program
{
    private static bool opcao(Conta bancoInter)
    {
        
        Console.WriteLine("1- Data de criação da conta");
        Console.WriteLine("2- Sacar");
        Console.WriteLine("3- Depositar");
        Console.WriteLine("4- Ver saldo");
        float valor;
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine();
                Console.WriteLine("Conta criada em: " + bancoInter.DataCriacao);
                Console.WriteLine();
                return true;
            case "2":
                Console.WriteLine();
                Console.WriteLine("Valor:");
                valor = float.Parse(Console.ReadLine());
                Console.WriteLine("Saldo atual: " + bancoInter.Sacar(valor));
                Console.WriteLine();
                return true;
            case "3":
                Console.WriteLine();
                Console.WriteLine("Valor:");
                valor = float.Parse(Console.ReadLine());
                Console.WriteLine("Saldo atual: " + bancoInter.Depositar(valor));
                Console.WriteLine();
                return true;
            case "4":
                Console.WriteLine();
                Console.WriteLine("Saldo atual: " + bancoInter.Saldo);
                Console.WriteLine();
                return true;

            default:
                return false;


        }
    }

        static void Main()
        {
        Conta bancoInter = new Conta(1400, DateTime.Now);
        while (opcao(bancoInter));
        }
    }
