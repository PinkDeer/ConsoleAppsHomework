using System;

namespace Average
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Среднее арифмитическое двух чисел";

            string str;
            double a, b, resault;

            Console.WriteLine("Введите первое число:");
            str = Console.ReadLine();
            a = Convert.ToDouble(str);

            Console.WriteLine("Введите второе число:");
            str = Console.ReadLine();
            b = Convert.ToDouble(str);

            resault = (a + b) / 2;
            Console.WriteLine($"Среднее арифмитическое двух чисел: {resault}");

            Console.ReadKey();
        }
    }
}
