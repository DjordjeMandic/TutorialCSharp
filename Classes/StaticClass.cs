using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    static class StaticClass
    {
        public static void WL(object o)
        {
            Console.WriteLine(o);
        }

        public static string RL()
        {
            return Console.ReadLine();
        }
    }
}
