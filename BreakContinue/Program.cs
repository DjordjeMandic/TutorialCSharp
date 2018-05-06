using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
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
