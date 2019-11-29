using System;

namespace MultiplicationAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cумма и произведение 3 чисел";

            string str;

            double a, b, c, sum, multi;

            Console.WriteLine("Введите первое число:");
            str = Console.ReadLine();
            a = Convert.ToDouble(str);

            Console.WriteLine("Введите первое число:");
            str = Console.ReadLine();
            b = Convert.ToDouble(str);

            Console.WriteLine("Введите первое число:");
            str = Console.ReadLine();
            c = Convert.ToDouble(str);

            sum = a + b + c;
            multi = a * b * c;

            Console.WriteLine($"Сумма ввёденых чисел равна {sum}, произведение равно {multi}.");

            Console.ReadKey();

            //Вариант 2

            //double firstValue, secondValue, thirdValue, sum, multi;

            //Console.WriteLine("Введите число 1");
            //firstValue = double.Parse(Console.ReadLine());

            //Console.WriteLine("Введите число 2");
            //secondValue = double.Parse(Console.ReadLine());

            //Console.WriteLine("Введите число 3");
            //thirdValue = double.Parse(Console.ReadLine());

            //sum = firstValue + secondValue + thirdValue;
            //multi = firstValue * secondValue * thirdValue;

            //Console.WriteLine($"Сумма ввёденых чисел равна {sum}, произведение равно {multi}.");

            //Console.ReadKey();
        }
    }
}
