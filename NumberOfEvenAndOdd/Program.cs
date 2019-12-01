using System;

namespace NumberOfEvenAndOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая будет считать количество четных и нечетных чисел в том диапазоне, который укажет пользователь, а так же их сумму
            Console.Title = "Количество четных и нечетных";

            // Вариант 1

            while (true)
            {
                int min, limit; // Начало и конец диапазона

                uint evenCount = 0; // Количетво чётыных
                uint oddCount = 0; // Количетво нечётыных

                int sumEven = 0; // Сумма чётыных
                int sumOdd = 0; // Сумма нечётыных

                try
                {
                    Console.WriteLine("Введите минимальное значение диапазона");
                    min = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите максимальное значение диапазона");
                    limit = int.Parse(Console.ReadLine());
            }
                catch (Exception)
            {
                Console.WriteLine("Вы вели строку, а не число");
                continue;
            }

            if (min >= limit)
            {
                Console.WriteLine("Вы неверно указали значения диапазона");
                continue;
            }

            Console.WriteLine("");

                while (min <= limit)
                {
                    if (min % 2 == 0)
                    {
                        evenCount++;
                        sumEven = sumEven + min;
                    }
                    else
                    {
                        oddCount++;
                        sumOdd = sumOdd + min;
                    }
                    min++;
                }

                Console.WriteLine($"Количество чётных чисел в указанном диапазоне: {evenCount}, их сумма {sumEven}");
                Console.WriteLine($"Количество нечётных чисел в указанном диапазоне: {oddCount}, их сумма {sumOdd}");

                Console.WriteLine("");
                Console.WriteLine("Для продолжения нажмите на любую клавишу");
                Console.ReadLine();

            }

            //Вариант 2

            /*            uint oddNuberCount = 0; // нечётные числа
                        uint evenNuberCount = 0; // чётные числа

                        int oddNumberSum = 0;
                        int evenNumberSum = 0;

                        Console.WriteLine("Введите первое число диапазона:");
                        int currentValue = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите последнее число диапазона:");
                        int limit = int.Parse(Console.ReadLine());

                        while (currentValue <= limit)
                        {
                            if (currentValue % 2 == 0)
                            {
                                evenNuberCount++;
                                evenNumberSum += currentValue;
                            }
                            else
                            {
                                oddNuberCount++;
                                oddNumberSum += currentValue;
                            }
                            currentValue++;
                        }

                        Console.WriteLine($"Количество нечётных чисел: {oddNuberCount}");
                        Console.WriteLine($"Количество чётных чисел: {evenNuberCount}");
                        Console.WriteLine($"Сумма нечётных чисел: {oddNumberSum}");
                        Console.WriteLine($"Сумма чётных чисел: {evenNumberSum}");
                        Console.ReadLine();*/

        }
    }
}
