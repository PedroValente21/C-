using System;
using System.Collections.Generic;

class Pai
{
    public string i = "Pai";
    public virtual void Papai()
    {
        Console.WriteLine(i);
    }
}

class Filho : Pai
{
    public new string i = "Filho";
    public override void Papai()
    {
        Console.WriteLine("----------");
        base.Papai();
        Console.WriteLine(i);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pai pai = new Pai();
        Filho filho = new Filho();
        pai.Papai();
        filho.Papai();
    }
}