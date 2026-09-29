using System;

class Program
{
    static void Main()
    {
        int n1, n2;
        Console.Write("Digite o primeiro número: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        n2 = int.Parse(Console.ReadLine());

        if (n1 > 0 && n2 > 0)
        {
            Console.WriteLine("Ambos os números são POSITIVOS.");
        }
        else if (n1 < 0 && n2 < 0)
        {
            Console.WriteLine("Ambos os números são NEGATIVOS.");
        }
        else
        {
            Console.WriteLine("Os números têm sinais diferentes.");
        }
    }
}
