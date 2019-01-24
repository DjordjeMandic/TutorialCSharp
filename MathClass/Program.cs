using System;

namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi broj: ");

            var broj = Convert.ToDouble(Console.ReadLine());

            var stepen2 = Math.Pow(broj, 2); // kvadrat

            Console.WriteLine($"Kvadrat: {stepen2}"); // "Kvadrat: " + stepen2

            var koren2 = Math.Sqrt(broj); // drugi koren (obican koren)

            Console.WriteLine($"Koren: {koren2}");

            var kub = Math.Pow(broj, 3);

            Console.WriteLine($"Kub: {kub}");

            var koren3 = Math.Pow(broj, 1.0 / 3);

            Console.WriteLine("Treci koren: " + koren3);

            var apsolutno = Math.Abs(broj);

            Console.WriteLine("Apsolutno: " + apsolutno);

            var zaokruzeno = Math.Round(broj, 5); // broj, broj decimala

            Console.WriteLine("Zaokruzeno: " + zaokruzeno);

            var logbaza10 = Math.Log10(broj); // Math.Log(broj, 10);

            Console.WriteLine("Log10: " + logbaza10);

            var logbaza2 = Math.Log(broj, 2);

            Console.WriteLine("Log2: " + logbaza2);

            Console.WriteLine("Pi: " + Math.PI);
            Console.WriteLine("E: " + Math.E);


            var floored = Math.Floor(broj);

            Console.WriteLine("Floored: " + floored);

            var ugao = Math.PI * broj / 180.00;

            var sinus = Math.Sin(ugao);

            Console.WriteLine("Sinus: " + sinus);

            var asinus = Math.Asin(broj);

            var ugaoasin = 180.00 * asinus / Math.PI;

            Console.WriteLine("Asinus: " + ugaoasin);

            var min1 = Math.Min(3515, -5);
            var min2 = Math.Min(1, 34543);
            Console.WriteLine($"Min1: {min1} + Min2: {min2}");

            Console.WriteLine(Math.BigMul(int.MaxValue, Convert.ToInt32(broj)));
        }
    }
}
