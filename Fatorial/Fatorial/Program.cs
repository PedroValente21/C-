using System;
class Calculo
{
    public int fatorial(int x)
    {
        if (x == 0 || x == 1)
        {
            return 1;
        } else if (x > 0) { 
            return x * fatorial(x - 1);
        } else {
            return -1;
        }
    }

    static void Main(string[] args)
    {
        int valor = int.Parse(Console.ReadLine());
        int resultado;
        Calculo calculo = new Calculo();
        resultado = calculo.fatorial(valor);
        Console.WriteLine(resultado);
    }
}