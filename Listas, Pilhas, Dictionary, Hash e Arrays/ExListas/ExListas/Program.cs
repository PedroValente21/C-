using System.Collections;


public class Program
{
    static void Main()
    {
        Queue qe = new Queue();
        qe.Enqueue(1); qe.Enqueue(2); qe.Enqueue(3); qe.Enqueue(4); qe.Enqueue(5);

        ArrayList copiaQueue = CopiarQueueParaArrayList(qe);
        Console.WriteLine("Metodo copia queue pra arraylist");
        for (int i = 0; i < copiaQueue.Count; i++)
        {
            Console.WriteLine(copiaQueue[i]);
        }
        Console.WriteLine("");

        Queue copiaQueue2 = CopiarQueue(qe);
        Console.WriteLine("Metodo copia queue");
        foreach (var item in copiaQueue2)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("");


        Stack st = new Stack();
        st.Push(1); st.Push(2); st.Push(3); st.Push(4); st.Push(5);
        Stack copiaStack = CopiarStack(st);
        Console.WriteLine("Metodo copia stack");
        foreach (var item in copiaStack)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("");

        Stack fundoStack = VaiProFundo(st, 3);
        Console.WriteLine("Metodo fundo stack");
        foreach (var item in fundoStack)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("");

        Queue inverterQueue = InverterQueue(qe);
        Console.WriteLine("Metodo inverter queue");
        foreach (var item in inverterQueue)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("");

        Stack inverterStack = InverterStack(st);
        Console.WriteLine("Metodo inverter stack");
        foreach (var item in inverterStack)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("");

        Hashtable hs = new Hashtable();
        Hashtable hs2 = new Hashtable();
        hs.Add(1, 10); hs.Add(2, 20); hs.Add(3, 30); hs.Add(4, 40); hs.Add(5, 50);
        hs2.Add(6, 60); hs2.Add(7, 70); hs2.Add(8, 80); hs2.Add(9, 90); hs2.Add(10, 100);
        Hashtable concatenaHashtable = concatenarHashtable(hs, hs2);
        Console.WriteLine("Metodo concatenar Hashtable");
        foreach (var item in concatenaHashtable)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("");
    }

    public static ArrayList CopiarQueueParaArrayList(Queue origem)
    {

        ArrayList novaLista = new ArrayList();
        foreach (var item in origem)
        {
            novaLista.Add(item);
        }

        return novaLista;
    }

    public static Queue CopiarQueue(Queue origem)
    {

        Queue q = new Queue();

        foreach (var item in origem)
        {
            q.Enqueue(item);
        }

        return q;
    }

    public static Stack CopiarStack(Stack origem)
    {

        Stack q = new Stack();

        foreach (var item in origem)
        {
            q.Push(item);
        }

        return q;
    }

    public static Stack VaiProFundo(Stack origem, int n)
    {
        Stack q = new Stack();
        int qtd = origem.Count;

        for (int i = 0; i < qtd; i++)
        {
            q.Push(origem.Pop());
        }

        origem.Push(n);

        for (int i = 0; i < qtd; i++)
        {
            origem.Push(q.Pop());
        }

        return origem;
    }

    public static Queue InverterQueue(Queue q)
    {
        Stack queue = new Stack();
        int qtd = q.Count;

        for (int i = 0; i < qtd; i++)
        {
            queue.Push(q.Dequeue());
        }

        for (int i = 0; i < qtd; i++)
        {
            q.Enqueue(queue.Pop());
        }

        return q;
    }

    public static Stack InverterStack(Stack origem)
    {
        Stack q = new Stack();
        int qtd = origem.Count;

        for (int i = 0; i < qtd; i++)
        {
            q.Push(origem.Pop());
        }

        for (int i = 0; i < qtd; i++)
        {
            origem.Push(q.Pop());
        }

        return origem;
    }

    public static Hashtable concatenarHashtable(Hashtable origem1, Hashtable origem2)
    {
        Hashtable hs = new Hashtable();

        foreach (DictionaryEntry de in origem1)
        {
            hs.Add(de.Key, de.Value);
        }
        foreach (DictionaryEntry d2 in origem2)
        {
            hs.Add(d2.Key, d2.Value);
        }

        return hs;
    }
}
