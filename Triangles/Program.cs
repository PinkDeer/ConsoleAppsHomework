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

            Console.ReadLine();
        }
    }
}