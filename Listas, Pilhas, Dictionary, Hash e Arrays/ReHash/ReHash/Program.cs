using System;
using System.Collections.Generic;

class TabelaHashDireta
{
    private int[] tabela;
    private int tamanhoTabela;

    public TabelaHashDireta(int tamanhoTabela)
    {
        this.tamanhoTabela = tamanhoTabela;
        tabela = new int[tamanhoTabela];
        for (int i = 0; i < tamanhoTabela; i++)
        {
            tabela[i] = int.MinValue;
        }
    }

    private int Hash(int numero)
    {
        return numero % tamanhoTabela;
    }


    public bool Inserir(int numero)
    {
        int indice = Hash(numero);
        if (tabela[indice] == int.MinValue)
        {
            tabela[indice] = numero;
            return true;
        }
        else
        {
            if (tabela[indice + 1] == int.MinValue)
            {
                tabela[indice + 1] = numero;
                return true;
            }
        }
        return false;
    }

    public bool Remover(int numero)
    {
        int indice = Hash(numero);
        if (tabela[indice] == numero)
        {
            tabela[indice] = int.MinValue;
            return true;
        }
        else if (tabela[indice + 1] == numero)
        {
            tabela[indice + 1] = int.MinValue;
            return true;
        } else
        {
            return false;
        }
    }

    public bool Pesquisar(int numero)
    {
        int indice = Hash(numero);
        if (tabela[indice] == numero)
        {
            return true;
        }
        else if (tabela[indice + 1] == numero)
        {
            return true;
        } else
        {
            return false;
        }
    }

    public void Listar()
    {
        for (int i = 0; i < tamanhoTabela; i++)
        {
            Console.WriteLine($"Posição {i}: {(tabela[i] == int.MinValue ? "Vazia" : tabela[i].ToString())}");
        }
    }
}


class Program
{
    public static void Main()
    {
        int escolha = 0;
        TabelaHashDireta tabela = new TabelaHashDireta(7);

        for (int c = 0; escolha != 1977; c++)
        {
            Console.WriteLine("1 - Inserir pessoa");
            Console.WriteLine("2 - Remover pessoa");
            Console.WriteLine("3 - Listar pessoas");
            Console.WriteLine("4 - Pesquisar pessoa");
            Console.WriteLine("5 - Sair");

            escolha = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (escolha == 1)
            {
                Console.WriteLine("Digite o número:");
                int valor = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                tabela.Inserir(valor);
            }
            else if (escolha == 2)
            {
                Console.WriteLine("Qual valor deseja remover?:");
                int valor = int.Parse(Console.ReadLine());
                tabela.Remover(valor);
                Console.WriteLine("");
            }
            else if (escolha == 3)
            {
                tabela.Listar();
                Console.WriteLine("");
            }
            else if (escolha == 4)
            {
                Console.WriteLine("Qual valor deseja visualizar?:");
                int valor = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                tabela.Pesquisar(valor);
                Console.WriteLine("");
            }
        }

    }
}