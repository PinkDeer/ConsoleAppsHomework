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

            //Вариант 2

            //double firstValue, secondValue, result;

            //Console.WriteLine("Введите число 1:");
            //firstValue = double.Parse(Console.ReadLine());

            //Console.WriteLine("Введите число 2:");
            //secondValue = double.Parse(Console.ReadLine());

            //result = (firstValue + secondValue) / 2;
            //Console.WriteLine($"Среднее арифмитическое двух чисел: {resault}");

            //Console.ReadKey();
        }
    }
}
