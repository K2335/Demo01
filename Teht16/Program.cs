using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int arpa = rnd.Next(1, 100);
            int arvaus = 999;

            while (arvaus != arpa) { 
                Console.Write("Arvaa luku: ");
                arvaus = int.Parse(Console.ReadLine());
                if (arvaus < arpa)
                    Console.WriteLine("Luku on suurempi");
                if (arvaus > arpa)
                    Console.WriteLine("Luku on pienempi");
            }
            Console.WriteLine("Arvasit oikein!");

        }
    }
}
