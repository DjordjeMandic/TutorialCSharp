using System; // koristimo sve unutar system namespace-a

namespace Osnove
{
    internal class Program
    {
        private static void Main(string[] args) // ovo je metod i zove se "Main"
        {
            /*Console.WriteLine("Ovo je tekst koji smo napisali."); // pozvali smo konzolu i rekli joj da ispise tekst i novi red
            Console.ReadLine(); // cekamo da korisnik pritisne enter*/
            var a = 2;
            while(true)
            {
                a = a + 5000000;
                Console.WriteLine(a^2);
            }
        } // nema nista
    } // nema nista
} // nema nista