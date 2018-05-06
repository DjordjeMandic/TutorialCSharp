using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode
{
    class Program
    {
        static void Main(string[] args)
        {
            WL("Test");
            WL(saberiText("asd", " dsa"));
            WL(oduzmi(15, 5));
            RL();
        }

        static void RL() // novi metod koji se zove RL
        {
            Console.ReadLine();
        }

        static void WL(string text)
        {
            Console.WriteLine(text);
        }

        static void WL(object obj)
        {
            Console.WriteLine(obj);
        }

        static string saberiText(string s1, string s2)
        {
            return s1 + s2;
        }

        static int oduzmi(int a, int b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            return a - b;
        }
    }
}
