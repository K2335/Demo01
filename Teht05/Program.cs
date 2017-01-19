using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            int sekunnit;
            Console.Write("Type seconds: ");
            sekunnit = int.Parse(Console.ReadLine());

            int tunnit = sekunnit / 3600;
            int min = sekunnit / 60 - tunnit * 60;
            int sek = sekunnit % 60;

            Console.WriteLine("Tunnit: " + tunnit + " Minuutit: " + min + " Sekunit: " + sek);

        }
    }
}
