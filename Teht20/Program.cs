using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht20
{
    class Program
    {
        static void Main(string[] args)
        {
            int valinta = 0;
            while (true)
            {
                Console.WriteLine("Laskin");
                Console.WriteLine("Valitse toiminto");
                Console.WriteLine("0. Lopetus");
                Console.WriteLine("1. Summa");
                Console.WriteLine("2. Erotus");
                Console.WriteLine("3. Tulo");
                

                valinta = int.Parse(Console.ReadLine());
                if (valinta == 0)
                {
                    System.Environment.Exit(1);
                }
                int luku1;
                int tulos;
                Console.Write("Anna luku: ");
                luku1 = int.Parse(Console.ReadLine());

                int luku2;
                Console.Write("Anna luku: ");
                luku2 = int.Parse(Console.ReadLine());

             
                if (valinta == 1)
                {
                    tulos = luku1 + luku2;
                    Console.WriteLine("Vastaus on: " + tulos);
                }
                if (valinta == 2)
                {
                    tulos = luku1 - luku2;
                    Console.WriteLine("Vastaus on: " + tulos);
                }
                if (valinta == 3)
                {
                    tulos = luku1 * luku2;
                    Console.WriteLine("Vastaus on: " + tulos);
                }
              
            }

        


        }
    }
}
