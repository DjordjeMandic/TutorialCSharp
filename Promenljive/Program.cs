using System;

namespace Promenljive
{
    class Program
    {
        static void Main(string[] args)
        {
            int starost = 16;
            string ime = "Djordje";
            bool punoletan = false;

            // nesto uradimo
            Console.WriteLine(ime + " ima " + starost + " godina i nije punoletan.");
            Console.WriteLine(punoletan);
            Console.WriteLine("Pritisni enter da nastavis program.");
            Console.ReadLine(); // ceka da korisnik pritisne enter

            // 2 godine kasnije
            starost = 18;
            punoletan = true;

            Console.WriteLine("Dve godine kasnije, " + ime + " ima " + starost + " godina i on je sada punoletan");
            Console.WriteLine("Punoletan: " + punoletan);
            Console.ReadLine();*/

            var starost = 14;
            var ime = "Marko";
            var punoletan = false;

            Console.WriteLine(ime + " ima " + starost + " godina.");
            Console.WriteLine("Punoletan: " + punoletan);
            Console.ReadLine();
        }
    }
}
