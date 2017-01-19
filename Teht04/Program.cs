using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Type your age: ");
            age = int.Parse(Console.ReadLine());

            if (age < 18) Console.WriteLine("Underage");
            if (age >= 18 && age <= 65) Console.WriteLine("Adult");
            else Console.WriteLine("Seniori");
        }
    }
}
