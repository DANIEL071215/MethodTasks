using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();

        }

        private static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }

        private static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to ___________________");
            Console.WriteLine("Received by ___________________");
        }

        private static void PrintReceiptFooter()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine($"\u00A9 SoftUni");
        }

        private static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("-----------------------");

        }
    }
}
