using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tau1 = { 10, 20, 30 , 40, 50 };

            int[] tau2 = { 5, 15, 25, 35, 45 };

            int[] combined = tau1.Concat(tau2).ToArray();


            Array.Sort(combined);
            foreach (int value in combined)
            {
                Console.Write(value);
                Console.Write(",");
            }
           
        }
    }
}
