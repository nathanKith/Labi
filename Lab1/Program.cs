using System;
using System.IO;

namespace laboratoryWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Толпаров Натан ИУ5-31Б");
            double A, B, C;
            args = new string[3];
            do
            {
                try
                {
                    Console.Write("Введите коэффициенты: \nA = ");
                    args[0] = Console.ReadLine();
                    A = double.Parse(args[0]);
                    Console.Write("B = ");
                    args[1] = Console.ReadLine();
                    B = double.Parse(args[1]);
                    Console.Write("C = ");
                    args[2] = Console.ReadLine();
                    C = double.Parse(args[2]);
                    Console.WriteLine($"{A}x^4 + {B}x^2 + {C} = 0");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите корректные данные!");
                    continue;
                }
            } while (true);

        }
    }
}
