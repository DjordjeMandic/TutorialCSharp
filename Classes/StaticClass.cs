using System;

namespace Classes
{
    internal static class StaticClass
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