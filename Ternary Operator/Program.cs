using System;

namespace Ternary_Operator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int a = 8;
            int b = 5;
            /*if (a < b)
                Console.WriteLine("A je manje od B");
            else
                Console.WriteLine("A je vece od B");*/

            //                   uslov ? ako je tacno : ako je netacno
            //string zaKonzolu = (a < b) ? "A je manje od B" : "A je vece od b";
            Console.WriteLine((a < b) ? "tacno" : "netacno");

            int test = (a < b) ? 1 : 0;
            Console.WriteLine(test);

            Console.WriteLine((a < b) ? 1 : 0);
        }
    }
}