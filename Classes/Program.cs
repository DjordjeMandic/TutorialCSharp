using System;

namespace Classes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var pas1 = new Pas("Cezar", 6, Zivotinja.Pol.Musko, Pas.Vrsta.sarplaninac);
            var pas2 = new Pas("Badi", 4, Zivotinja.Pol.Zensko, Pas.Vrsta.pitbul);

            var macka = new Macka("Mujs", 2, Zivotinja.Pol.Musko, true);

            StaticClass.WL("Pas se zove: " + pas1.Ime + " i ima " + pas1.Starost + " godina.");
            if (Pas.Pol.Musko == pas1.PolZivotinje)
            {
                StaticClass.WL("U pitanju je muski pas.");
            }
            else
            {
                StaticClass.WL("U pitanju je zenski pas.");
            }

            StaticClass.WL("Pas se zove: " + pas2.Ime + " i ima " + pas2.Starost + " godina.");
            if (Pas.Pol.Musko == pas2.PolZivotinje)
            {
                StaticClass.WL("U pitanju je muski pas.");
            }
            else
            {
                StaticClass.WL("U pitanju je zenski pas.");
            }

            if (Pas.Vrsta.pitbul == pas1.VrstaPsa)
            {
                StaticClass.WL("Pas 1 je pitbul");
            }
            else
            {
                StaticClass.WL("Pas 1 je sar planincac");
            }

            switch (pas2.VrstaPsa)
            {
                case Pas.Vrsta.pitbul:
                    StaticClass.WL("Pas 2 je pit bul");
                    break;

                case Pas.Vrsta.sarplaninac:
                    StaticClass.WL("Pas 2 je sar planinac");
                    break;

                default:
                    StaticClass.WL("Pas 2 vrsta nepoznata");
                    break;
            }

            StaticClass.WL("Macka se zove " + macka.Ime + " i ima " + macka.Starost + " godina.");

            StaticClass.WL("Godinu dana kasnije...");
            Console.ReadLine();
            macka.Starost = macka.Starost + 1;
            StaticClass.WL("Macka se zove " + macka.Ime + " i ima " + macka.Starost + " godina.");

            macka.haha();
            pas1.haha();
            pas2.tuzan();
            macka.tuzan();
            pas1.tuzan();

            StaticClass.RL();
        }
    }
}