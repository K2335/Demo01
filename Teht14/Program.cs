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

            
            foreach (var item in numbers)
                Console.WriteLine("*");

        }
    }
}
