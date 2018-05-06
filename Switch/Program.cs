using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            var broj = "123";
            switch (broj)
            {
                case "0":
                    Console.WriteLine("Nula");
                    break;
                case "1":
                    Console.WriteLine("Jedan");
                    break;
                case "2":
                    Console.WriteLine("Dva");
                    break;
                case "3":
                    Console.WriteLine("Tri");
                    break;
                default:
                    Console.WriteLine("Ne mozemo naci");
                    break;
            }
            Console.ReadLine();
        }
    }
}
