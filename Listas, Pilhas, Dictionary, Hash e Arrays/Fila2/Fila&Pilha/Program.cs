using System.Collections;

class Program
{
    static void Main()
    {
        Queue fila = new Queue();
        string letra;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Digite uma letra");
            letra = Console.ReadLine();

            if (letra.All(char.IsLetter)){
                if (letra == letra.ToUpper())
                {
                    fila.Enqueue(letra);
                }
                else if (letra == letra.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine(fila.Dequeue());
                }
            } else
            {
                Console.WriteLine("");
                Console.WriteLine(fila.Peek());
            }

            Console.WriteLine("");
        }
    }
}