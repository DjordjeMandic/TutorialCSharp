using System;

namespace Metode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WL("Test");
            WL(saberiText("asd", " dsa"));
            WL(oduzmi(15, 5));
            RL();
        }

        private static void RL() // novi metod koji se zove RL
        {
            Console.ReadLine();
        }

        private static void WL(string text)
        {
            Console.WriteLine(text);
        }

        private static void WL(object obj)
        {
            Console.WriteLine(obj);
        }

        private static string saberiText(string s1, string s2)
        {
            return s1 + s2;
        }

        private static int oduzmi(int a, int b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            return a - b;
        }
    }
}