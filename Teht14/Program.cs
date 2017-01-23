using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna arvosana: ");
            int arvo1 = int.Parse(Console.ReadLine());

            Console.Write("Anna arvosana: ");
            int arvo2 = int.Parse(Console.ReadLine());

            Console.Write("Anna arvosana: ");
            int arvo3 = int.Parse(Console.ReadLine());

            Console.Write("Anna arvosana: ");
            int arvo4 = int.Parse(Console.ReadLine());

            Console.Write("Anna arvosana: ");
            int arvo5 = int.Parse(Console.ReadLine());

            int[] numbers = new[] { arvo1, arvo2, arvo3, arvo4, arvo5 };

            Console.Write("Nollia: ");
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] == 0) { 
                    Console.Write("*");
                }
            }
            Console.WriteLine();
            Console.Write("Ykkosia: ");
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] == 1)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
            Console.Write("Kakkosia: ");
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] == 2)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
            Console.Write("Kolmosia: ");
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] == 3)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
            Console.Write("Nelosia: ");
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] == 4)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
            Console.Write("Vitosia: ");
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] == 5)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
