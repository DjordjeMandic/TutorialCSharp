using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static int[] intarray = { 1, 2, 3, 4, 5 };
        static string[] test = { "3", "2", "1" };
        static List<string> stringList = new List<string>();
        static List<bool> boolList = new List<bool>();

        static void Main(string[] args)
        {
            Console.WriteLine(intarray[0]);
            Console.WriteLine(intarray[1]);
            Console.WriteLine(intarray[2]);
            Console.WriteLine(intarray[3]);
            Console.WriteLine(intarray[4]);

            Console.WriteLine(test[1]);

            Console.ReadLine();

            intarray[2] = 55;

            Console.WriteLine(intarray[2]);

            Console.ReadLine();

            for (int temp = 0; temp < intarray.Length; temp++)
            {
                Console.WriteLine(intarray[temp]);
            }

            Console.ReadLine();

            foreach (int broj in intarray)
            {
                Console.WriteLine(broj);
            }


            Console.ReadLine();

            stringList.Add(Console.ReadLine());
            stringList.Add(Console.ReadLine());
            stringList.Add(Console.ReadLine());
            stringList.Add(Console.ReadLine());
            stringList.Add(Console.ReadLine());
            stringList.Add(Console.ReadLine());

            foreach (string temp in stringList)
            {
                Console.WriteLine(temp);
            }

            boolList.Add(true);
            boolList.Add(false);
            //...

            foreach (bool temp in boolList)
            {
                Console.WriteLine(temp);
            }

            Console.ReadLine();
        }
    }
}
