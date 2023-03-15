using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintHeaderRow(number);
            PrintMiddleRow(number);
            PrintMiddleRow(number); 
            PrintFooterRow(number);

        }

        static void PrintFooterRow(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }

        static void PrintMiddleRow(int number)
        {
            Console.Write('-');
            for (int i = 1; i < number; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        static void PrintHeaderRow(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }
    }
}
