using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Конверт валют";

            string str;
            double a, s, resault;
            s = 0.016;

            Console.WriteLine("Введите сумму в рублях:");
            str = Console.ReadLine();
            a = Convert.ToDouble(str);

            resault = a * s;

            Console.WriteLine($"По курсу 64,08 рублей за доллар, {a} рублей равно {resault} долларов.");

            Console.ReadKey();

            //Вариант 2

            //double rub, dollar;

            //Console.WriteLine("Введите сумму в рублях:");
            //rub = double.Parse(Console.ReadLine());

            //dollar = 0.016;

            //Console.WriteLine($"По курсу 64,08 рублей за доллар, {rub} рублей равно {rub * dollar} долларов.");

            //Console.ReadKey();

            //Вариант 3

            //double UsdToRub = 66.29;
            //double UsdToUah = 27.24;
            //double USD;

            //Console.WriteLine("Ввведите сумму в USD");
            //USD = double.Parse(Console.ReadLine());

            //Console.WriteLine($"{USD} в рубли = {USD * UsdToRub}");
            //Console.WriteLine($"{USD} в гривеы = {USD * UsdToUah}");

            //Console.ReadKey();
        }
    }
}
