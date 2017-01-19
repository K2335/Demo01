using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance;
            Console.Write("Input distance you want to travel: ");
            distance = double.Parse(Console.ReadLine());

            double consumption = distance / 100 * 7.02;
            Console.WriteLine("Consumption: " + consumption);

            double price = consumption * 1.595;
            Console.WriteLine("Price: " + price);
        }
    }
}
