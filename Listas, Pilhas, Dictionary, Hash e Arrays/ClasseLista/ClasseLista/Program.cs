using System;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Data.Common;


class Lista
{
    public int[] array;
    public int n;

    public Lista()
    {
        array = new int[6];
        n = 0;
    }

    public Lista(int tamanho)
    {
        array = new int[tamanho];
        n = 0;
    }

    public void inserirInicio(int x)
    {
        for (int i = n; i > 0; i--)
        {
            array[i] = array[i - 1];
        }

        array[0] = x;
        n++;
    }
    public void RemoverInicio()
    {

        n--;

        for (int i = 0; i < n; i++)
        {
            array[i] = array[i + 1];
        }
       
    }
    public void inserirFim(int x)
    {
        array[n] = x;
        n++;
    }

    public void RemoverFim()
    {
        n--;
    }

    public void inserir(int x, int y)
    {
        for (int i = n; i > y; i--)
        {
            array[i] = array[i - 1];
        }


        array[y] = x;
        n++;
    }

    public void Remover(int x)
    {
        n--;

        for (int i = n; i > x; i--)
        {
            array[i - 1] = array[i];
        } 
    }

    public void Soma()
    {
        int elemento;
        int total = 0;
        for (int i = 0; i < n; i++)
        {
            elemento = array[i];
            total += elemento;
        }

        Console.WriteLine("===== SOMA DOS ELEMENTOS =====");
        Console.WriteLine(total);
    }

    public void Maior()
    {
        int elemento = 0;
        int teste;
        for (int i = 0; i < n; i++)
        {
            teste = array[i];
            if (teste > elemento)
            {
                elemento = array[i];
            } 
        }

        Console.WriteLine("===== MAIOR ELEMENTO =====");
        Console.WriteLine(elemento);
    }

    public void Inverter() 
    {
        int[] invertido;
        invertido = new int[n];
        int c = 0;
        for (int i = n; i > 0; i--)
        {
            invertido[c] = array[i - 1];
            c++;
        }
        Console.WriteLine("===== INVERTIDO =====");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(invertido[i]);
        }
    }

    public void Ordenada()
    {
        int[] ordenada = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            int elemento = array[i];
            int j = i;

            while (j > 0 && elemento < ordenada[j - 1])
            {
                ordenada[j] = ordenada[j - 1]; 
                j--;
            }

            ordenada[j] = elemento;
        }

        Console.WriteLine("===== ORDENADA =====");
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(ordenada[i]);
        }
    }


    public void PareMultiplo()
    {
        int elemento1;
        int elemento2;
        Console.WriteLine("===== PAR E MULTIPLO DE 5 =====");
        for (int i = 0; i < n; i++)
        {
            elemento1 = array[i];
            elemento1 = elemento1 % 2;
            elemento2 = array[i];
            elemento2 = elemento2 % 5;
            if (elemento1 == 0 || elemento2 == 0)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

    public void Mostrar()
    {
        for(int i = 0; i < n;i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine("===== LISTA LINEAR =====");
        Lista lista = new Lista(6);
        lista.inserirInicio(1);
        lista.inserirFim(7);
        lista.inserirFim(9);
        lista.inserirInicio(3);
        lista.inserir(8, 3);
        lista.inserir(4, 2);

        lista.Mostrar();
        Console.WriteLine("======================");

        lista.RemoverInicio();
        lista.RemoverFim();
        lista.Remover(2);

        lista.Mostrar();

        lista.Soma();
        lista.Maior();
        lista.Inverter();
        lista.PareMultiplo();
        lista.Ordenada();

    }
}