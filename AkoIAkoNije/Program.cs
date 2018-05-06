using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoIAkoNije
{
    class Program
    {
        static void Main(string[] args)
        {
            var ime = "Petar";
            var starost = -5;

            // manje jednako: <=
            // vece jedanko: >=
            // manje i vece: < i >
            // jedanko: ==

            

            if (starost == 0) // proveravamo da li ima 0 godina
            {
                // ako ima 0 godina
                Console.WriteLine(ime + " jos nije rodjen.");
            }
            else // ako nema 0 godina
            {
                if (starost < 18) // proveravamo jel ima manje od 18 godina
                {
                    // ima manje od 18 god
                    Console.WriteLine(ime + " ima " + starost + " godina i nije punoletan.");
                }
                else // ako nema manje od 18 godina
                {
                    // nema manje od 18 god
                    Console.WriteLine(ime + " ima " + starost + " godina i jeste punoletan.");
                }

                if (starost >= 18 && starost <= 65) // proveravamo da li ima izmedju 18 i 65 godina
                {
                    // ako ima
                    Console.WriteLine(ime + " jos uvek moze da bude zaposlen.");
                }
                else if (starost > 65) // ako nema proveravamo ima li vise od 65 godina
                {
                    // ako ima vise od 65
                    Console.WriteLine(ime + " je u penziji.");
                }
                else if (starost < 18) // ako nema vise od 65 proveravmo da li ima manje od 18 godina
                {
                    // ako ima manje od 18 godina
                    Console.WriteLine(ime + " ne moze da bude zaposlen posto nije punoletan.");
                }
                else
                {
                    // ako je nepoznato
                    Console.WriteLine("Nepoznata mogucnost.");
                }
            }

            Console.ReadLine();
        }
    }
}
