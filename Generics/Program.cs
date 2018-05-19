using System;

namespace Generics
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var nasaStringLista = new NasaLista<string>(5);
            var nasaIntLista = new NasaLista<int>(5);
            var nasaBoolLista = new NasaLista<bool>(5);

            nasaStringLista.NamestiVrednost(2, "Ovo je tekst na drugom mestu");
            nasaStringLista.NamestiVrednost(3, "Ovo je tekst na trecem mestu");

            nasaIntLista.NamestiVrednost(1, 555);
            nasaIntLista.NamestiVrednost(4, 333);

            nasaBoolLista.NamestiVrednost(2, true);
            nasaBoolLista.NamestiVrednost(5, false);

            Console.WriteLine(nasaStringLista.ProcitajVrednost(2));
            Console.WriteLine(nasaStringLista.ProcitajVrednost(3));

            Console.WriteLine(nasaIntLista.ProcitajVrednost(1));
            Console.WriteLine(nasaIntLista.ProcitajVrednost(4));

            Console.WriteLine(nasaBoolLista.ProcitajVrednost(2));
            Console.WriteLine(nasaBoolLista.ProcitajVrednost(5));

            Console.WriteLine(nasaStringLista.ProcitajVrednost(4));

            Console.WriteLine(nasaIntLista.ProcitajVrednost(3));

            Console.WriteLine(nasaBoolLista.ProcitajVrednost(1));

            Console.ReadLine();
        }
    }
}