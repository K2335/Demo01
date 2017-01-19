using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            int points;
            Console.Write("Give points");
            points = int.Parse(Console.ReadLine());
            
            switch(points)
            {
                case 0: Console.WriteLine("Your grade is 0"); break;
                case 1: Console.WriteLine("Your grade is 0"); break;
                case 2: Console.WriteLine("Your grade is 1"); break;
                case 3: Console.WriteLine("Your grade is 1"); break;
                case 4: Console.WriteLine("Your grade is 2"); break;
                case 5: Console.WriteLine("Your grade is 2"); break;
                case 6:
                case 7: Console.WriteLine("Your grade is 3"); break;
                case 8:
                case 9: Console.WriteLine("Your grade is 4"); break;
                case 10:
                case 11: Console.WriteLine("Your grade is 5"); break;

            }
            Console.ReadLine();
        }
    }
}
