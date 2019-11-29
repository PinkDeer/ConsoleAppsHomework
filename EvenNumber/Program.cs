using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, проверяющую число, введеное с клавиатуры на четность

            Console.Title = "Проверка числа на четность";

            double number;

            Console.WriteLine("Введите число:");
            number = double.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число не чётное");
            }

            Console.ReadKey();
        }
    }
}
