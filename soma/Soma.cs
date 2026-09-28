using System;

class Program
{
    static void Main(string[] args)
    {
        int n1, n2, n3, n4, n5, soma;

        Console.WriteLine("Digite um numero inteiro:");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um numero inteiro:");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um numero inteiro:"); 
        n3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um numero inteiro:");
        n4 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um numero inteiro:");
        n5 = int.Parse(Console.ReadLine());
        soma = n1 + n2 + n3 + n4 + n5;  
        Console.WriteLine("Soma: " + soma);
    }
}
