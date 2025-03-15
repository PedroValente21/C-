using System;

class Soma
{
    static void Main()
    {
        int num1, num2, soma;

        Console.WriteLine("Digite o primeiro valor: ");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        num2 = int.Parse(Console.ReadLine());

        soma = num1 + num2;
        Console.WriteLine("");
        Console.WriteLine("Total= "+soma);
    }
}
