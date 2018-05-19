using System;
using System.Threading;

namespace ConsoleKalkulator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Za sabiranje ukucaj +");
                Console.WriteLine("Za oduzimanje ukucaj -");
                Console.WriteLine("Za mnozenje ukucaj *");
                Console.WriteLine("Za deljenje ukucaj /");

                switch (Console.ReadLine())
                {
                    case "+":
                        Sabiranje();
                        break;

                    case "-":
                        Oduzimanje();
                        break;

                    case "*":
                        Mnozenje();
                        break;

                    case "/":
                        Deljenje();
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greska: " + ex.Message);
            }
        }

        private static void Sabiranje()
        {
            Console.WriteLine("Odabrao si sabiranje, molimo unestie broj a");
            int brojA;
            if (!int.TryParse(Console.ReadLine(), out brojA))
            {
                Console.WriteLine("Neuspesno ocitavanje broja a");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }

            Console.WriteLine("Odabrao si sabiranje, molimo unestie broj b");
            int brojB;
            if (!int.TryParse(Console.ReadLine(), out brojB))
            {
                Console.WriteLine("Neuspesno ocitavanje broja b");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }

            Console.WriteLine("Resenje je: " + Kalkulator<int>.Saberi(brojA, brojB));
        }

        private static void Oduzimanje()
        {
            Console.WriteLine("Odabrao si oduzimanje, molimo unestie broj a");
            int brojA;
            if (!int.TryParse(Console.ReadLine(), out brojA))
            {
                Console.WriteLine("Neuspesno ocitavanje broja a");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }

            Console.WriteLine("Odabrao si oduzimanje, molimo unestie broj b");
            int brojB;
            if (!int.TryParse(Console.ReadLine(), out brojB))
            {
                Console.WriteLine("Neuspesno ocitavanje broja b");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }

            Console.WriteLine("Resenje je: " + Kalkulator<int>.Oduzmi(brojA, brojB));
        }

        private static void Mnozenje()
        {
            Console.WriteLine("Odabrao si mnozenje, molimo unestie broj a");
            double brojA;
            if (!double.TryParse(Console.ReadLine(), out brojA))
            {
                Console.WriteLine("Neuspesno ocitavanje broja a");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }

            Console.WriteLine("Odabrao si mnozenje, molimo unestie broj b");
            double brojB;
            if (!double.TryParse(Console.ReadLine(), out brojB))
            {
                Console.WriteLine("Neuspesno ocitavanje broja b");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }

            Console.WriteLine("Resenje je: " + Kalkulator<double>.Pomnozi(brojA, brojB));
        }

        private static void Deljenje()
        {
            Console.WriteLine("Odabrao si deljenje, molimo unestie broj a");
            decimal brojA;
            if (!decimal.TryParse(Console.ReadLine(), out brojA))
            {
                Console.WriteLine("Neuspesno ocitavanje broja a");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }

            Console.WriteLine("Odabrao si deljenje, molimo unestie broj b");
            decimal brojB;
            if (!decimal.TryParse(Console.ReadLine(), out brojB))
            {
                Console.WriteLine("Neuspesno ocitavanje broja b");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }

            Console.WriteLine("Resenje je: " + Kalkulator<decimal>.Podeli(brojA, brojB));
        }
    }
}