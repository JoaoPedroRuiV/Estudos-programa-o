using System;

class Program
{
    static void Main()
    {
        int numero;

        Console.Write("Digite um número: ");
        numero = Convert.ToInt32(Console.ReadLine());

        for (int i = numero; i <= 20; i ++)
        {
            Console.WriteLine($"Numero digitado {i}");
        }

        Console.WriteLine ("Numero invalido");
    }
}

