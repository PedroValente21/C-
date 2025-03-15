using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> queue = new Queue<int>();
        Stack<int> stack = new Stack<int>();

        queue.Enqueue(1);
        stack.Push(1);
        queue.Enqueue(3);
        stack.Push(3);
        queue.Enqueue(5);
        stack.Push(5);
        queue.Enqueue(10);
        stack.Push(10);
        queue.Enqueue(30);
        stack.Push(30);
        queue.Enqueue(50);
        stack.Push(50);
        queue.Dequeue();
        stack.Pop();


        if (queue.Contains(30))
        {
            Console.WriteLine("Contém");
        }

        if (stack.Contains(30))
        {
            Console.WriteLine("Contém");
        }

        int peek = queue.Peek();
        Console.WriteLine(peek);
        peek = stack.Peek();
        Console.WriteLine(peek);

        queue.Clear();
        stack.Clear();
        Console.WriteLine(queue.Count);
        Console.WriteLine(stack.Count);
    }
}