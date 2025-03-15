using System.Collections;

class Program
{
    static void Main()
    {
        Stack pilha = new Stack();
        string letra;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Digite uma letra");
            letra = Console.ReadLine();

            if (letra.All(char.IsLetter))
            {
                if (letra == letra.ToUpper())
                {
                    pilha.Push(letra);
                }
                else if (letra == letra.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine(pilha.Pop());
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine(pilha.Peek());
            }

            Console.WriteLine("");
        }
    }
}