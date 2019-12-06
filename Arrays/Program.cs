using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Заполнить массив с клавиатуры
            // 2. Вывести массив в обратном порядке
            // 3. Найти сумму четных чисел в массиве
            // 4. Найти наименьшее число в массиве

            while (true)
            {
                int count; // количество элементов в массиве

                try
                {
                    Console.Write("\nВведите количество элементов массива: ");
                    count = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nНекорректный формат вводимых данных.");
                    Console.ReadKey();
                    continue;
                }

                int[] Array = new int[count]; // объявление массива

                try // добавление элементов в массив
                {
                    for (int i = 0; i < Array.Length; i++)
                    {
                        Console.Write("\nВведите значение элемента массива: ");
                        Array[i] = int.Parse(Console.ReadLine());
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nНекорректный формат вводимых данных.");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("\nМассив в обратном порядке:");

                int evenSum = 0;
                int even;

                for (int i = Array.Length; i > 0; i--)
                {
                    Console.WriteLine(Array[i-1]);

                    even = Array[i - 1];
                    if (even % 2 == 0)
                    {
                        evenSum = evenSum + even;
                    }
                   
                }

                Console.WriteLine($"\nCумма четных {evenSum}");


                Console.WriteLine($"Минимальное значение: {Array.Min()}");

                Console.ReadLine();
            }

        }
    }
}
