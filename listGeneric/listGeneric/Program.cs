using System;
using System.Collections.Generic;

class Aluno : IComparable<Aluno>
{
    public int matricula;
    public string nome;
    public string email;

    public Aluno()
    {
        this.nome = "";
        this.email = "";
        this.matricula = 0;
    }

    public Aluno(string nome, string email, int matricula)
    {
        this.nome = nome;
        this.email = email;
        this.matricula = matricula;
    }

    public void Mostrar()
    {
        Console.WriteLine(nome + " --- " + matricula + " --- " + email);
    }

    public int CompareTo(Aluno other)
    {
        return this.matricula.CompareTo(other.matricula);
    }
}

class AlunoComparer : IComparer<Aluno>
{
    public int Compare(Aluno x, Aluno y)
    {
        return x.matricula.CompareTo(y.matricula);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        List<Aluno> list = new List<Aluno>();
        Random random = new Random();

        for (int i = 0; i < 20; i++)
        {
            int num = random.Next(100);
            list.Add(new Aluno("Aluno " + num, "aluno" + num + "@gmail.com", num));
        }

        Console.WriteLine("Lista original:");
        foreach (Aluno aluno in list)
        {
            aluno.Mostrar();
        }

        Console.WriteLine("====================================================");

        list.Sort();

        Console.WriteLine("Lista ordenada:");
        foreach (Aluno aluno in list)
        {
            aluno.Mostrar();
        }

        Console.WriteLine("====================================================");

        Aluno a = list[random.Next(100) % list.Count];
        int posicao = list.BinarySearch(a, new AlunoComparer());
        Console.WriteLine("Posição de("+ a.nome +"): "+ posicao);
        a.nome = "José";
        posicao = list.BinarySearch(a, new AlunoComparer());
        Console.WriteLine("Posição de(" + a.nome + "): " + posicao);
    }
}
