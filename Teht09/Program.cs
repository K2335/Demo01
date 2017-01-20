using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true) {
                int luku;
                int luku2;
                Console.Write("Anna luku: ");           
                luku = int.Parse(Console.ReadLine());

                Console.Write("Anna luku: ");
                luku2 = int.Parse(Console.ReadLine());

                Console.Write("Tulos on: ");
                Console.WriteLine(luku + luku2);

            }
        }
    }
}
