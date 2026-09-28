using System;

class Hipotenusa
{
    static void Main()
    {
        double hipotenusa, cateto1, cateto2;
        Console.WriteLine("Digite o valor do cateto 1:");
        cateto1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor do cateto 2:");
        cateto2 = double.Parse(Console.ReadLine());
        hipotenusa = Math.Sqrt(cateto1 * cateto1 + cateto2 * cateto2);
        Console.WriteLine("O valor da hipotenusa é: " + hipotenusa);
    }
}
