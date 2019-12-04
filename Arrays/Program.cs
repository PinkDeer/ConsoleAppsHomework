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
                int number;
                int even;

                try
                {
                    for (int i = 0; i < Array.Length; i++)
                    {
                        Console.Write("Введите занчение элемента массива: ");
                        number = int.Parse(Console.ReadLine());
                        Array[i] = number;
                        
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели строку, а не число.");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine("Массив в обратном порядке:");

                int evenSum = 0;

                for (int i = Array.Length; i > 0; i--)
                {
                    Console.WriteLine(Array[i-1]);

                    even = Array[i - 1];
                    if (even % 2 == 0)
                    {
                        evenSum = evenSum + even;
                    }
                    
                    Console.WriteLine($"Чётное {even}");
                    Console.WriteLine($"Cумма четных {evenSum}");
                }

                Console.WriteLine();

                Console.ReadLine();
            }

        }
    }
}
