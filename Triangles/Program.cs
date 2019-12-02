using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {

            // Использую вложенные массивы нарисовать в консоли треугольники

            Console.Title = "Треугольники";

            // Первый треугольник

            uint count = 1;

            for (int i = 1; i <= 10; i++)
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

            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j >= count; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                count += 1;
            }

            Console.WriteLine();

            // Третий треугольник

            count = 1;

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 9; j >= count; j--)
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

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 2; j <= count; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 10; k >= count; k--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                count += 1;
            }

            Console.ReadLine();
        }
    }
}