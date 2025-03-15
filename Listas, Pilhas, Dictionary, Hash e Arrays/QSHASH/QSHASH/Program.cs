using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Stack pilha = new Stack();

        pilha.Push(1); pilha.Push(2); pilha.Push(3); pilha.Push(4); pilha.Push(5);
        Console.WriteLine(pilha.Count);
        Console.WriteLine("");
        pilha.Pop();
        string teste = "Não";
        if (pilha.Contains(1)) {
            teste = "Sim";
        }
        Console.WriteLine(teste);
        Console.WriteLine("");
        teste = "Não";
        if (pilha.Contains(5))
        {
            teste = "Sim";
        }
        Console.WriteLine(teste);
        Console.WriteLine("");
        Console.WriteLine(pilha.Peek());
        Console.WriteLine("");
        pilha.Push(6); pilha.Push(7); pilha.Push(8); pilha.Push(9); pilha.Push(10);
        Console.WriteLine(pilha.Pop());
        Console.WriteLine(pilha.Pop());

        pilha.Clear();
        Console.WriteLine(pilha.Count);
    }
}