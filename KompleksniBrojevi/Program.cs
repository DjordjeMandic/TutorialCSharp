using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace KompleksniBrojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Realna: ");
            var re = Convert.ToDouble(Console.ReadLine());
            Console.Write("Imaginarna: ");
            var im = Convert.ToDouble(Console.ReadLine());

            var complex = new Complex(re, im);

            Console.WriteLine($"Z = {complex.Real} + {complex.Imaginary}i             {complex.ToString()}");

            Console.WriteLine($"|Z| = {complex.Magnitude}");

            Console.WriteLine($"φ = {complex.Phase}rad");

            var ugaostep = 180.00 * complex.Phase / Math.PI;
            Console.WriteLine($"φ = {ugaostep}°");

            var complex2 = new Complex(2, 4);

            var zbir = complex + complex2;

            Console.WriteLine(zbir);
        }
    }
}
