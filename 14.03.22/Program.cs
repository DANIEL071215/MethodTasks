using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._03._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi tip ");
            string type = Console.ReadLine();
            if (type == "int")
            {
                Console.WriteLine("Vuvedi purvoto chislo ");
                int first = int.Parse(Console.ReadLine());
                Console.WriteLine("Vuvedi vtoroto chislo ");
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine($"Po golqmoto chislo e {max}");
            }
            else if (type == "char")
            {
                Console.WriteLine("Vuvedi purvi simvol ");
                char first = char.Parse(Console.ReadLine());
                Console.WriteLine("Vuvedi vtoriq simvol ");
                char second = char.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine($"Po golemiqt simvol e {(char)max}");
            }
            else if (type == "string")
            {
                Console.WriteLine("Vuvedi purviq niz ot simvoli ");
                string first = Console.ReadLine();
                Console.WriteLine("Vuvedi vtoriq niz ot simvoli ");
                string second = Console.ReadLine();
                string max = GetMax(first, second);
                Console.WriteLine($"Po golemiqt niz ot simvoli e {max}");
            }


        }

        private static int GetMax(int first, int second)
        {
            int result = 0;
            if (first>second)
            {
                result = first;
                return result;
            }
            else
            {
                result = second;
                return result;
            }
        }

            private static string GetMax(string first, string second)
        {
            string result = "";
            if (first.CompareTo(second) >= 0)
            {
                result = first;
                return result;
            }
            else
            {
                result = second;
                return result;

            }
        }
        private static int GetMax(char first, char second)
        {
            int result = 0;
            if ((int) first>(int)second)
            {
                result = first;
                return result;
            }
            else
            {
                result = second;
                return result;
            }
        }
    }
}
