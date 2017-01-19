using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            Console.Write("Give number1: ");
            number1 = int.Parse(Console.ReadLine());

            int number2;
            Console.Write("Give number2: ");
            number2 = int.Parse(Console.ReadLine());

            int number3;
            Console.Write("Give number3: ");
            number3 = int.Parse(Console.ReadLine());

            int sum = number1 + number2 + number3;
            Console.WriteLine("Summa on" + sum);
            int average = sum / 3;
            Console.WriteLine("Keskiarvo on" + average);

        }
    }
}
