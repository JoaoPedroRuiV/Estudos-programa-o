using System;

class INSS
{
    static void Main()
    {
        Console.Write("Digite o salário: ");
        double salario = double.Parse(Console.ReadLine());

        double descontoINSS;

        if (salario <= 1000.00)
        {
            descontoINSS = salario * 0.08;
        }
        else if (salario <= 2000.00)
        {
            descontoINSS = salario * 0.09;
        }
        else if (salario <= 3000.00)
        {
            descontoINSS = salario * 0.11;
        }
        else
        {
            descontoINSS = salario * 0.12;
        }

        Console.WriteLine($"Desconto do INSS: {descontoINSS}");
    }
}