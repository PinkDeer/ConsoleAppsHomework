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
        }
    }
}
