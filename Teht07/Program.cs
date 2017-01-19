using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("Input year: ");
            year = int.Parse(Console.ReadLine());


            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("Leap year");
            }
            else Console.WriteLine("Not a leap year");

            /*
            int cent;
            cent = year % 400;
            switch(cent)
            {
                case 0:
                    Console.WriteLine("Leap year");
                    System.Environment.Exit(1);
                    break;
            }

            int century;
            century = year % 100;
            switch(century)
            {
                case 0:
                    Console.WriteLine("Not a leap year");
                    System.Environment.Exit(1);
                    break;
            }

            
            int leap;
            leap = year % 4;
         
            if (leap == 0)
                Console.WriteLine("Leap Year!");
            else Console.WriteLine("Not a leap year");
            */
        }
    }
}
