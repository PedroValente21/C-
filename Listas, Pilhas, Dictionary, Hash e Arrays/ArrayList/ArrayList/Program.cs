using System;
using System.Collections;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;


class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        int var;

        do
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adicionar elemento");
            Console.WriteLine("2 - Remover elemento");
            Console.WriteLine("3 - Listar elementos");
            Console.WriteLine("4 - Pesquisar elemento");
            Console.WriteLine("5 - Ordenar elementos");
            Console.WriteLine("6 - Sair");
            Console.WriteLine("");
            var = int.Parse(Console.ReadLine());

            if (var == 1)
            {
                Console.WriteLine("Digite o elemento:");
                string elemento = Console.ReadLine();
                Console.WriteLine("");

                list.Add(elemento);
                Console.WriteLine("Item adicionado: " + list[list.Count - 1]);
                Console.WriteLine("");

            }
            else if (var == 2)
            {
                Console.WriteLine("Digite a posição do elemento a ser removido:");
                int posição = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (posição < 0 || posição >= list.Count)
                {
                    Console.WriteLine("Posição inválida. A posição deve estar entre 0 e " + (list.Count - 1) + ".");
                    Console.WriteLine("");
                }
                else
                {
                    object elementoRemovido = list[posição];
                    list.RemoveAt(posição);
                    Console.WriteLine("Item removido: " + elementoRemovido);
                    Console.WriteLine("");
                }
            }
            else if (var == 3)
            {
                Console.WriteLine("Elementos na lista:");
                if (list.Count == 0)
                {
                    Console.WriteLine("A lista está vazia.");
                    Console.WriteLine("");
                }
                else
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine($"{i}: {list[i]}");
                    }
                    Console.WriteLine("");
                }
            }
            else if (var == 4)
            {
                Console.WriteLine("Digite o elemento a ser pesquisado:");
                string elementoPesquisado = Console.ReadLine();
                Console.WriteLine("");
                int indice = list.IndexOf(elementoPesquisado);

                if (indice != -1)
                {
                    Console.WriteLine($"Elemento '{elementoPesquisado}' encontrado na posição: {indice}");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine($"Elemento '{elementoPesquisado}' não encontrado na lista.");
                    Console.WriteLine("");
                }
            }
            else if (var == 5)
            {
                if (list.Count == 0)
                {
                    Console.WriteLine("A lista está vazia. Não é possível ordenar.");
                    Console.WriteLine("");
                }
                else
                {
                    list.Sort();
                    Console.WriteLine("Lista ordenada com sucesso.");
                    Console.WriteLine("");
                }
            }

        } while (var != 6);

        Console.WriteLine("Saindo...");
        Console.WriteLine("");


        ArrayList listaCopiada = CopiarArrayList(list);
        ArrayList listaCopiadaParte = CopiarParteArrayList(list, 5, 3);
        ArrayList apagarParteLista = ApagarArrayList(list, 3, 7);

        Console.WriteLine("Classe listaCopiada");
        for (int i = 0; i < listaCopiada.Count; i++)
        {
            Console.WriteLine($"{i}: {listaCopiada[i]}");
        }
        Console.WriteLine("");
        Console.WriteLine("Classe listaCopiadaParte");
        for (int i = 0; i < listaCopiadaParte.Count; i++)
        {
            Console.WriteLine($"{i}: {listaCopiadaParte[i]}");
        }

        Console.WriteLine("");
        Console.WriteLine("Classe apagarParteLista");
        for (int i = 0; i < apagarParteLista.Count; i++)
        {
            Console.WriteLine($"{i}: {apagarParteLista[i]}");
        }

        ArrayList concatenaLista = concatenaArrayList(list, apagarParteLista);

        Console.WriteLine("");
        Console.WriteLine("Classe concatenaArrayList");
        for (int i = 0; i < concatenaLista.Count; i++)
        {
            Console.WriteLine($"{i}: {concatenaLista[i]}");
        }

        ArrayList intersecao = intersecaoArrayList(list, apagarParteLista);
        Console.WriteLine("");
        Console.WriteLine("Classe intersecaoArrayList");
        for (int i = 0; i < intersecao.Count; i++)
        {
            Console.WriteLine($"{i}: {intersecao[i]}");
        }

        ArrayList uniao = uniaoArrayList(list, apagarParteLista);
        Console.WriteLine("");
        Console.WriteLine("Classe uniaoArrayList");
        for (int i = 0; i < uniao.Count; i++)
        {
            Console.WriteLine($"{i}: {uniao[i]}");
        }

        ArrayList repetidos = apagarRepetidosList(list);
        Console.WriteLine("");
        Console.WriteLine("Classe apagarRepetidosList");
        for (int i = 0; i < repetidos.Count; i++)
        {
            Console.WriteLine($"{i}: {repetidos[i]}");
        }

        ArrayList ocorrencias = ocorrenciasDe(list, list[3]);
        Console.WriteLine("");
        Console.WriteLine("Classe ocorrenciasDe");
        for (int i = 0; i < ocorrencias.Count; i++)
        {
            Console.WriteLine($"{i}: {ocorrencias[i]}");
        }

        ArrayList qtdocorrencias = qtdOcorrencias(list, list[3]);
        Console.WriteLine("");
        for (int i = 0; i < qtdocorrencias.Count; i++)
        {
            Console.WriteLine($"Quantidade de ocorrencias: {qtdocorrencias[i]}");
        }
    }

    public static ArrayList CopiarArrayList(ArrayList origem)
    {
        ArrayList novaLista = new ArrayList();

        for (int i = 0; i < origem.Count; i++)
        {
            novaLista.Add(origem[i]);
        }

        return novaLista;
    }

    public static ArrayList CopiarParteArrayList(ArrayList origem, int inicio, int final)
    {
        ArrayList novaLista = new ArrayList();

        if(origem.Count < final)
        {
            for (int i = 0; i < origem.Count; i++)
            {
                novaLista.Add(origem[i]);
            }
        } else
        {
            for (int i = 0; i < inicio; i++)
            {
                novaLista.Add(origem[i]);
            }

            origem.Reverse();

            for (int i = 0; i < final; i++)
            {
                novaLista.Add(origem[i]);
            }

        }

        return novaLista;
    }

    public static ArrayList ApagarArrayList(ArrayList origem, int inicio, int final)
    {
        ArrayList novaLista = new ArrayList();
        origem.Reverse();

        for (int i = inicio; i <= final; i++)
        {
            novaLista.Add(origem[i]);
        }

        return novaLista;
    }

    public static ArrayList concatenaArrayList(ArrayList origem1, ArrayList origem2)
    {
        ArrayList novaLista = new ArrayList();

        for (int i = 0; i < origem1.Count; i++)
        {
            novaLista.Add(origem1[i]);
        }

        for (int i = 0; i < origem2.Count; i++)
        {
            novaLista.Add(origem2[i]);
        }

        return novaLista;
    }

    public static ArrayList intersecaoArrayList(ArrayList origem1, ArrayList origem2)
    {
        ArrayList novaLista = new ArrayList();

        for (int i = 0; i < origem1.Count; i++)
        {
            for (int y = 0; y < origem2.Count; y++)
            {
                if (origem1[i] == origem2[y])
                {
                    novaLista.Add(origem1[i]);
                }

            }

        }

        return novaLista;
    }

    public static ArrayList uniaoArrayList(ArrayList origem1, ArrayList origem2)
    {
        ArrayList novaLista = new ArrayList();
        

        for (int i = 0; i < origem1.Count; i++)
        {
            for (int y = 0; y < origem2.Count; y++)
            {
                if (origem1[i] == origem2[y])
                {
                    break;
                } else if (y == (origem2.Count - 1))
                {
                    novaLista.Add(origem1[i]);
                }
            }
        }


        return novaLista;
    }

    public static ArrayList apagarRepetidosList(ArrayList origem)
    {
        ArrayList novaLista = new ArrayList();

        for (int i = 0; i < origem.Count; i++)
        {
            if (!novaLista.Contains(origem[i]))
            {
                novaLista.Add(origem[i]);
            }
        }

        return novaLista;
    }

    public static ArrayList ocorrenciasDe(ArrayList origem, object elemento)
    {
        ArrayList novaLista = new ArrayList();

        for (int i = 0; i < origem.Count; i++)
        {
            if (origem[i].Equals(elemento))
            {
                novaLista.Add(i);
            }
        }

        return novaLista;
    }

    public static ArrayList qtdOcorrencias(ArrayList origem, object elemento)
    {
        ArrayList novaLista = new ArrayList();
        int contador = 0;

        for (int i = 0; i < origem.Count; i++)
        {
            if (origem[i].Equals(elemento))
            {
                contador++;
            }
        }

        novaLista.Add(contador);

        return novaLista;
    }
}
