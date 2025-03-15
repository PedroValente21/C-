using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Queue fila = new Queue();

        fila.Enqueue(1); fila.Enqueue(2); fila.Enqueue(3); fila.Enqueue(4); fila.Enqueue(5);
        Console.WriteLine(fila.Count);
        Console.WriteLine("");
        fila.Dequeue();
        string teste = "Não";
        if (fila.Contains(1))
        {
            teste = "Sim";
        }
        Console.WriteLine(teste);
        Console.WriteLine("");
        teste = "Não";
        if (fila.Contains(5))
        {
            teste = "Sim";
        }
        Console.WriteLine(teste);
        Console.WriteLine("");
        Console.WriteLine(fila.Peek());
        Console.WriteLine("");
        fila.Enqueue(6); fila.Enqueue(7); fila.Enqueue(8); fila.Enqueue(9); fila.Enqueue(10);
        Console.WriteLine(fila.Dequeue());
        Console.WriteLine(fila.Dequeue());

        fila.Clear();
        Console.WriteLine(fila.Count);
    }
}

