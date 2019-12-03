using System;

namespace Triangles
{

    /*    class Program
        {
            static void Main(string[] args)
            {

                // Использую вложенные массивы нарисовать в консоли треугольники

                Console.Title = "Треугольники";

                // Первый треугольник

                Console.Write("Высота треугольника: ");
                int height = int.Parse(Console.ReadLine());

                uint count = 1;

                for (int i = 1; i <= height; i++)
                {
                    for (int j = 1; j <= count; j++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                    count += 1;
                }

                Console.WriteLine();

                // Второй треугольник

                count = 1;

                for (int i = 0; i < height; i++)
                {
                    for (int j = height; j >= count; j--)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                    count += 1;
                }

                Console.WriteLine();

                // Третий треугольник

                count = 1;

                for (int i = 1; i <= height; i++)
                {
                    for (int j = (height-1); j >= count; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= count; k++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                    count += 1;
                }

                Console.WriteLine();

                // Четвёртый треугольник

                count = 1;

                for (int i = 1; i <= height; i++)
                {
                    for (int j = 2; j <= count; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = height; k >= count; k--)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                    count += 1;
                }

                Console.ReadLine();
            }
        }*/

    // Вариант 2

/*    class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("Высота высоту треугольника: ");
            int height = int.Parse(Console.ReadLine());

            // Первый треугольник

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            // Второй треугольник

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            // Третий треугольник

            for (int i = 0; i < height; i++)
            {
                for (int j = height-1; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            // Третий треугольник версия 2

      *//*      for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(height - i, i + 1);
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

            }

            Console.ReadLine();*//*

            // Четввертый треугольник

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = height; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }*/
}