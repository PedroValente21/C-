using System;

class Notas
{
    static void Main()
    {
        string[] alunos = new string[5];
        int[] notas = new int[5];
        int soma = 0;
        float media;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Digite o nome do aluno");
            alunos[i] = Console.ReadLine();
            Console.WriteLine("Digite a nota do aluno " + alunos[i]);
            notas[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("");
        }

        for (int i = 0; i < 5; i++) 
        { 
            soma = soma + notas[i];
        }

        media = soma / 5;

        Console.WriteLine("Os alunos que ficaram acima da média da turma foram:");
        for (int i = 0;  i < 5; i++)
        {
            if (notas[i] >= media) { 
            Console.WriteLine(alunos[i]+": " + notas[i]);
            }
            
        }
    }
}