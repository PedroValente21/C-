using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<int> list = new LinkedList<int>();

        list.AddFirst(1);
        list.AddAfter(list.AddFirst(5), 3);
        list.AddLast(10);
        list.AddBefore(list.AddLast(50), 30);

        list.Remove(3);
        list.RemoveFirst();
        list.RemoveLast();

        if (list.Contains(30))
        {
            Console.WriteLine("Contém");
        }

        list.Find(0);
        list.FindLast(30);



        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        list.Clear();
        Console.WriteLine(list.Count);
    }
}