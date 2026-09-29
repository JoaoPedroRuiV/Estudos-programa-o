using System;

class Program
{
    static void Main()
    {
       double salario, imposto;

        Console.Write("Digite o valor do salário: ");
        salario = Double.Parse(Console.ReadLine());

        if (salario <= 2000)
        {
            imposto = 0;
        }
        else if (salario <= 3000)
        {
            imposto = (salario - 2000) * 0.08;
        }
        else if (salario <= 4500)
        {
            imposto = (salario - 3000) * 0.18 + (1000 * 0.08);
        }
        else
        {
            imposto = (salario - 4500) * 0.28 + (1500 * 0.18) + (1000 * 0.08);
        }

        Console.WriteLine($"O imposto devido é: R$ {imposto}"); 
    }
}
