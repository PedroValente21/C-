using System;
using System.Collections.Generic;
using Contabil;
using Financeiro;


class Program
{
    public static void Main(string[] args)
    {
        Financeiro.Juros financeiro = new Financeiro.Juros();
        Contabil.Juros contabil = new Contabil.Juros();

        Console.WriteLine("Classe no namespace financeiro: {0}", financeiro.Valor);
        Console.WriteLine("Classe no namespace contabil: {0}", contabil.Valor);
    }
}