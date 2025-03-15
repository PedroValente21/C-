using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable ht = new Hashtable();
        ht.Add(1, 10); ht.Add(2, 20); ht.Add(3, 30); ht.Add(4, 40); ht.Add(5, 50);
        Console.WriteLine(ht.Count);
        Console.WriteLine("");
        ht.Remove(1);
        Console.WriteLine(ht.Contains(1));
        Console.WriteLine("");
        Console.WriteLine(ht.Contains(5));
        Console.WriteLine("");
        ht.Add(6, 60); ht.Add(7, 70); ht.Add(8, 80); ht.Add(9, 90); ht.Add(10, 100);
        ht.Clear();
        Console.WriteLine(ht.Count);
    }
}