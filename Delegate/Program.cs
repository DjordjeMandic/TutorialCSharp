using System;

namespace Delegate
{
    class Program
    {
        public delegate void NasDelegate(string s);
        public delegate int NasIntDelegate(string text, int broj);
        static void Main(string[] args)
        {
            var nd = new NasDelegate(Metod1);
            nd += Metod2;
            nd("Ovo je delegate");

            var nid = new NasIntDelegate(Metod1);
            nid += Metod2;
            nid("Broj je: ", 35);

            var nid1 = new NasIntDelegate(Metod2);
            nid1("Broj je:", 25);
        }

        static void Metod1(string text)
        {
            Console.WriteLine("Ja sam metod 1: " + text);
        }

        static void Metod2(string text)
        {
            Console.WriteLine("Ja sam metod 2: " + text);
        }

        static void Metod3()
        {
            Console.WriteLine();
        }

        static int Metod1(string t, int a)
        {
            Console.WriteLine("Ja sam int metod 1:" + t + a);
            return 0;
        }

        static int Metod2(string t, int a)
        {
            Console.WriteLine("Ja sam int metod 2:" + t + a);
            return 0;
        }
    }
}
