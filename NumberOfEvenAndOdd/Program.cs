using System;

namespace NumberOfEvenAndOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая будет считать количество четных и нечетных чисел в том диапазоне, который укажет пользователь

            while (true)
            {

                int min, limit;

                Console.Title = "Количество четных и нечетных";

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
               
                if (min > limit)
                {
                    Console.WriteLine("Вы неверно указали значения диапазона");
                    continue;
                }

                Console.WriteLine("");

                int even = 0; // Количетво чётыных
                int odd = 0; // Количетво нечётыных

                int sumEven = 0; // Сумма чётыных
                int sumOdd = 0; // Сумма нечётыных

                while (min < limit)
                {
                    min++;
                    if (min % 2 == 0)
                    {
                        even++;
                        sumEven = sumEven + min;
                    }
                    else
                    {
                        odd++;
                        sumOdd = sumOdd + min;
                    }

                }

                Console.WriteLine($"Количество чётных чисел в указанном диапазоне: {even}, их сумма {sumEven}");
                Console.WriteLine($"Количество нечётных чисел в указанном диапазоне: {odd}, их сумма {sumOdd}");

                Console.WriteLine("");
                Console.WriteLine("Для продолжения нажмите на любую клавишу");
                Console.ReadLine();

            }
        }
    }
}
