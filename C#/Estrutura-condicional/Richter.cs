using System;

class Program
{
    static void Main(string[] args)
    {
      int richter;
      Console.Write("Digite a magnitude do terremoto na escala Richter: ");
      richter = int.Parse(Console.ReadLine());

      if (richter >= 0 && richter <= 4)
        {
            Console.WriteLine("Terremoto de baixa intensidade.");
        }
        else if (richter >= 5 && richter <= 6)
        {
            Console.WriteLine("Terremoto de média intensidade.");
        }
        else if (richter >= 7 && richter <= 8)
        {
            Console.WriteLine("Terremoto de alta intensidade.");
        }
        else if (richter >= 9 && richter <= 10)
        {
            Console.WriteLine("Terremoto de extrema intensidade.");
        }
        else
        {
            Console.WriteLine("Magnitude inválida.");
        }
}
}

