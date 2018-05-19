namespace ConsoleKalkulator
{
    internal class Kalkulator<Tip>
    {
        public static Tip Saberi(Tip a, Tip b)
        {
            dynamic a1 = a;
            dynamic b1 = b;

            return a1 + b1;
        }

        public static Tip Oduzmi(Tip a, Tip b)
        {
            dynamic a1 = a;
            dynamic b1 = b;

            return a1 - b1;
        }

        public static Tip Pomnozi(Tip a, Tip b)
        {
            dynamic a1 = a;
            dynamic b1 = b;

            return a1 * b1;
        }

        public static Tip Podeli(Tip a, Tip b)
        {
            dynamic a1 = a;
            dynamic b1 = b;

            return a1 / b1;
        }
    }
}