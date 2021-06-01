using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreugolnicPascala
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа Треугольника Паскаля");
            Console.Write("Введите количество строк: ");
            string input = Console.ReadLine();

            int n = Convert.ToInt32(input);

            // метод создания треугольника паскаля

            for (int y = 0; y < n; y++)
            {
                int c = 1;
                for (int q = 0; q < n - y; q++)
                {
                    Console.Write("   ");
                }

                for (int x = 0; x <= y; x++)
                {
                    Console.Write("   {0:D} ", c);
                    c = c * (y - x) / (x + 1);
                }
                Console.WriteLine();
             
            }
            Console.ReadKey();


        }
    }
}
    
