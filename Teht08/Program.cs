using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;

            Console.Write("Type first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Type second number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Type third number: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
                Console.WriteLine(num1 + " is the biggest number");
            if (num1 > num2 && num1 < num3)
                Console.WriteLine(num3 + " is the biggest number");
            if (num1 < num2 && num1 > num3)
                Console.WriteLine(num2 + " is the biggest number");
            if (num1 < num2 && num2 < num3)
                Console.WriteLine(num3 + " is the biggest number");
        }
    }
}
