using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        dictionary.Add(1, "primeiro");
        dictionary.Add(2, "segundo");
        dictionary.Add(3, "terceiro");
        dictionary.Add(4, "quarto");

        dictionary.Remove(2);

        if (dictionary.ContainsKey(3))
        {
            Console.WriteLine("Contém");
        }

        if (dictionary.ContainsValue("Quarto"))
        {
            Console.WriteLine("Contém");
        }

        bool teste = dictionary.TryGetValue(3, out string value);
        Console.WriteLine(teste + " " + value);


        foreach (KeyValuePair<int, string> item in dictionary)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }
        dictionary.Clear();

    }
}