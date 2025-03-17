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
    public int Numero 
    {
        get { return _numero; }
    }
}

class Program
{
    private static bool opcao(Conta x)
    {
        
        Console.WriteLine("1- Data de criação da conta");
        Console.WriteLine("2- Sacar");
        Console.WriteLine("3- Depositar");
        Console.WriteLine("4- Ver saldo");
        Console.WriteLine("5- Ver número da conta");
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
                Console.WriteLine("Saldo atual: " + x.Sacar(valor));
                Console.WriteLine();
                return true;
            case "3":
                Console.WriteLine();
                Console.WriteLine("Valor:");
                valor = float.Parse(Console.ReadLine());
                Console.WriteLine("Saldo atual: " + x.Depositar(valor));
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

            default:
                return false;


        }
    }

        static void Main()
        {
        Conta bancoInter = new Conta(1400, DateTime.Now);
        Conta bancoInter2 = new Conta(2000, DateTime.Now);
        Conta bancoInter3 = new Conta(4000, DateTime.Now);
        while (opcao(bancoInter));
        while (opcao(bancoInter2));
        while (opcao(bancoInter3));
    }
    }
