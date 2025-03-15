using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list = new List<int>();
        Queue<int> queue = new Queue<int>();
        Stack<int> stack = new Stack<int>();
        Dictionary<int, int> dict1 = new Dictionary<int, int>();
        Dictionary<int, int> dict2 = new Dictionary<int, int>();

        Console.WriteLine("Criando list, queue, stack e Dictionary:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Digite o valor:");
            int valor = int.Parse(Console.ReadLine());
            list.Add(valor);
            queue.Enqueue(valor);
            stack.Push(valor);

            if (i < 5)
            {
                dict1.Add(i, valor);
            }
            else
            {
                dict2.Add(i, valor);
            }
        }
        Console.WriteLine("===================================================");
        QtdeOcorrencias(list, 3);
        ApagaQueue(queue, 7, 10);
        CopiaQueue(queue);
        CopiaStack(stack);
        VaiProFundo(stack, 10);
        inverteQueue(queue);
        inverteStack(stack);
        ConcatenaDictionary(dict1, dict2);
    }

    public static int QtdeOcorrencias(List<int> origem, int elemento)
    {
        int qtd = 0;
        foreach(int i in origem)
        {
           if (elemento == i)
            {
                qtd++;
            }
        }

        Console.WriteLine("O elemento está armazenado " + qtd + " vezes na lista");
        Console.WriteLine("===================================================");

        return qtd;
    }
    public static void ApagaQueue(Queue<int> origem, int inicio, int final)
    {
        Queue<int> queue = new Queue<int>();

        foreach(int i in origem)
        {
            if(i > inicio && i < final)
            {
                queue.Enqueue(i);
            }
        }

        foreach(int y in queue)
        {
            Console.WriteLine(y);
        }
        Console.WriteLine("===================================================");
    }

    public static Queue CopiaQueue(Queue<int> origem)
    {
        Queue queue = new Queue();

        foreach(int i in origem)
        {
            queue.Enqueue(i);
        }

        foreach (int y in queue)
        {
            Console.WriteLine(y);
        }
        Console.WriteLine("===================================================");

        return queue;
    }

    public static void CopiaStack(Stack<int> origem)
    {
        Stack stack = new Stack();

        while (origem.Count > 0)
        {
            stack.Push(origem.Pop());
        }

        foreach (int y in stack)
        {
            origem.Push(y);
        }

        foreach (int y in origem)
        {
            Console.WriteLine(y);
        }
        Console.WriteLine("===================================================");

    }

    public static void VaiProFundo(Stack<int> origem, int elemento)
    {
        Stack<int> stack = new Stack<int>();

        while (origem.Count > 0)
        {
            stack.Push(origem.Pop());
        }

        origem.Push(elemento);

        foreach (int y in stack)
        {
            origem.Push(y);
        }

        foreach (int y in origem)
        {
            Console.WriteLine(y);
        }
        Console.WriteLine("===================================================");
    }

    public static void inverteQueue(Queue<int> origem)
    {
        Stack stack = new Stack();

        while (origem.Count > 0)
        {
            stack.Push(origem.Dequeue());
        }

        foreach (int y in stack)
        {
            Console.WriteLine(y);
        }
        Console.WriteLine("===================================================");

    }

    public static void inverteStack(Stack<int> origem)
    {
        Stack stack = new Stack();

        while (origem.Count > 0)
        {
            stack.Push(origem.Pop());
        }

        foreach (int y in stack)
        {
            Console.WriteLine(y);
        }
        Console.WriteLine("===================================================");

    }

    public static void ConcatenaDictionary(Dictionary<int, int> d1, Dictionary<int, int> d2)
    {
        foreach (KeyValuePair<int, int> item in d2)
        {
            d1.Add(item.Key, item.Value);
        }

        foreach (KeyValuePair<int, int> item in d1)
        {
            Console.WriteLine(item.Key + "-" + item.Value);
        }
    }
}