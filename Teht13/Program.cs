using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht13
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1;
            int luku2;
            int luku3;
            int luku4;
            int luku5;

            Console.Write("Anna pisteet: ");
            luku1 = int.Parse(Console.ReadLine());

            Console.Write("Anna pisteet: ");
            luku2 = int.Parse(Console.ReadLine());

            Console.Write("Anna pisteet: ");
            luku3 = int.Parse(Console.ReadLine());

            Console.Write("Anna pisteet: ");
            luku4 = int.Parse(Console.ReadLine());

            Console.Write("Anna pisteet: ");
            luku5 = int.Parse(Console.ReadLine());


            int[] numbers = new[] { luku1, luku2, luku3, luku4, luku5 };
            int min = numbers.Min();

            int max = numbers.Max();

            int tulos;
            tulos = luku1 + luku2 + luku3 + luku4 + luku5 - min - max;

            Console.Write("Tulos on: " + tulos);

        }
    }
}
