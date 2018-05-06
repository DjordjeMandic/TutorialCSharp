using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        enum Smer
        {
            Gore,
            Dole,
            Levo,
            Desno,
            Nepoznat
        }

        enum Boje
        {
            Crvena,
            Plava,
            Zelena
        }

        static void Main(string[] args)
        {
            var int_smer = new Random().Next(0,5);
            var trenutn_smer = new Smer();
            switch (int_smer)
            {
                case 0:
                    trenutn_smer = Smer.Desno;
                    break;
                case 1:
                    trenutn_smer = Smer.Dole;
                    break;
                case 2:
                    trenutn_smer = Smer.Gore;
                    break;
                case 3:
                    trenutn_smer = Smer.Levo;
                    break;
                default:
                    trenutn_smer = Smer.Nepoznat;
                    break;
            }

            switch (trenutn_smer)
            {
                case Smer.Desno:
                    Console.WriteLine("Predmet ide desno.");
                    break;
                case Smer.Dole:
                    Console.WriteLine("Predmet ide dole.");
                    break;
                case Smer.Gore:
                    Console.WriteLine("Predmet ide gore.");
                    break;
                case Smer.Levo:
                    Console.WriteLine("Predmet ide levo.");
                    break;
                case Smer.Nepoznat:
                    Console.WriteLine("Smer nepoznat");
                    break;
                default:
                    Console.WriteLine("trenutni smer nema dodeljeni smer");
                    break;
            }
            Console.ReadLine();
        }
    }
}
