using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um dia da semana: ");
        string dia = (Console.ReadLine());

        switch (dia)
        {
            case "Segunda-feira":
                Console.WriteLine("Descanso");
                break;
            case "Terça-feira":
                Console.WriteLine("Peito + Tríceps");
                break;
            case "Quarta-feira":
                Console.WriteLine("Costas + Bíceps");
                break;
            case "Quinta-feira":
                Console.WriteLine("Correr 5km");
                break;
            case "Sexta-feira":
                Console.WriteLine("lags + Ombros");
                break;
            case "Sábado":
                Console.WriteLine("Pedal 2h");
                break;
            case "Domingo":
                Console.WriteLine("Descanso");
                break;
            default:
                Console.WriteLine("Dia inválido. Digite um dia da semana.");
                break;




        }
    }
}

