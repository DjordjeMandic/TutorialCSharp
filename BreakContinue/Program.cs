using System;

namespace BreakContinue
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var i = 0;
            while (false)
            {
                Console.WriteLine(i++);
            }

            Console.ReadLine();
        }
    }
}