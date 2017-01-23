using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht18
{
    class Program
    {
        static void Main(string[] args)
        {
            string sana = "assa";
            string takaperin = "";
            for (int i = sana.Length - 1; i >= 0; i--)
            {
                takaperin += sana[i];
            }
            if (sana == takaperin)
                Console.Write("Palindromi");
            else Console.Write("Ei ole palindromi");
        }
    }
}
