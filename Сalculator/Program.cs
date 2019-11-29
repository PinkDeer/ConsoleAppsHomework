using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Калькулятор";

            //Вариант 1. switch

            double numOne, numTwo;

            Console.WriteLine("Введите число 1");
            numOne = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            numTwo = double.Parse(Console.ReadLine());

            Console.WriteLine("Какое операцию выполнить? (Введите \"+\", \"-\", \"*\" или \"/\")");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Сумма двух чисел {numOne + numTwo}");
                    break;                
                case "-":
                    Console.WriteLine($"Разность двух чисел {numOne - numTwo}");
                    break;                
                case "*":
                    Console.WriteLine($"Произведение двух чисел {numOne * numTwo}");
                    break;                
                case "/":
                    Console.WriteLine($"Деление двух чисел {numOne / numTwo}");
                    break;
                default:
                    Console.WriteLine("Некорректный символ");
                    break;
            }


            Console.ReadKey();

            //Вариант 2. if else

            double numOne2, numTwo2;

            Console.WriteLine("Введите число 1");
            numOne2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            numTwo2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Какое операцию выполнить? (Введите \"+\", \"-\", \"*\" или \"/\")");
            string operation2 = Console.ReadLine();

            if (operation2 == "+")
                Console.WriteLine($"Сумма двух чисел {numOne2 + numTwo2}");
            else if (operation2 == "-")
                Console.WriteLine($"Разность двух чисел {numOne2 - numTwo2}");
            else if (operation2 == "*")
                Console.WriteLine($"Произведение двух чисел {numOne2 * numTwo2}");
            else if (operation2 == "/")
                Console.WriteLine($"Деление двух чисел {numOne2 / numTwo2}");
            else
                Console.WriteLine("Некорректный символ");

            Console.ReadKey();
        }
    }
}
