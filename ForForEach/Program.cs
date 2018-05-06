using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (var broj = 1; broj <= 150000; broj++)
            {
                Console.WriteLine(broj);
            }*/

            int[] grupabrojeva = {1,2,3,4,12312,6,7,8,3254345,10};
            foreach (int broj in grupabrojeva)
            {
                Console.WriteLine(broj);
            }
            Console.ReadLine();
        }
    }
}
