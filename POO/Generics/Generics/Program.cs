using System;

 class Conjunto <T>
{
    static public bool disjuntos(T[] x, T[] y)
    {
        for (int i = 0; i < x.Length; i++)
        {
            for (int p = 0; p < y.Length; p++)
            {
                if (x[i].Equals(y[p]))
                {
                    return false;
                }
            }
        }
        return true;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        if (Conjunto<int>.disjuntos(new int[] { 1, 3, 5 }, new int[] { 2, 4, 6 }))
        {
            Console.WriteLine("Deu bom");
        } else
        {
            Console.WriteLine("Deu pau");
        }

        if (Conjunto<double>.disjuntos(new double[] { 1, 3, 5 }, new double[] { 2, 3, 6 }))
        {
            Console.WriteLine("Deu bom");
        }
        else
        {
            Console.WriteLine("Deu pau");
        }
    }
} 