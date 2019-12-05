using System;

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
                Console.Write("Введите количество элементов массива: ");
                int max = int.Parse(Console.ReadLine());

                int[] Array = new int[max];

                try
                {
                    for (int i = 0; i < Array.Length; i++)
                    {
                        Console.Write("\nВведите значение элемента массива: ");
                        Array[i] = int.Parse(Console.ReadLine());
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nВы ввели строку, а не число.");
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

                Console.ReadLine();
            }

        }
    }
}
