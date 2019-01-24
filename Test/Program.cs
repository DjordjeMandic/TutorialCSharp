using System;

namespace Test
{
    class Program
    {
        static bool greska;
        public static void Main(string[] args)
        {
            var rand = new UniqueRandomNumber();
            rand.NoPossibleNumber += Greska;
            
            for (int i = 0; i < 10000; i++)
            {
                
                rand.Next();
                rand.NextDouble();
            }

            Console.ReadLine();
        }

        private static void Greska(object sender, EventArgs e)
        {
            Console.WriteLine("Greska");
            greska = true;
        }
    }

    public class UniqueRandomNumber
    {
        System.Collections.Generic.List<int> generatedInts;
        System.Collections.Generic.List<double> generatedDoubles;
        System.Random random;

        public System.EventHandler NoPossibleNumber = delegate { };

        public UniqueRandomNumber()
        {
            random = new System.Random();
        }

        public UniqueRandomNumber(int Seed)
        {
            random = new System.Random(Seed);
        }

        public int? Next()
        {
            InitializeGeneratedInts();
            int num;
            do
            {
                if (generatedInts.Count == int.MaxValue - 1) { NoPossibleNumber?.Invoke(this, System.EventArgs.Empty); return null; }
                num = random.Next();
            } while (generatedInts.Contains(num));
            generatedInts.Add(num);
            return num;
        }

        public int? Next(int maxValue)
        {
            InitializeGeneratedInts();
            int num;
            do
            {
                if (new System.Collections.Generic.HashSet<int>(generatedInts).IsSupersetOf(System.Linq.Enumerable.Range(0, maxValue))) { NoPossibleNumber?.Invoke(this, System.EventArgs.Empty); return null; }
                num = random.Next(maxValue);
            } while (generatedInts.Contains(num));
            generatedInts.Add(num);
            return num;
        }

        public int? Next(int minValue, int maxValue)
        {
            InitializeGeneratedInts();
            int num;
            do
            {
                if (new System.Collections.Generic.HashSet<int>(generatedInts).IsSupersetOf(System.Linq.Enumerable.Range(minValue, maxValue))) { NoPossibleNumber?.Invoke(this, System.EventArgs.Empty); return null; }
                num = random.Next(minValue, maxValue);

            } while (generatedInts.Contains(num));
            generatedInts.Add(num);
            return num;
        }

        public double NextDouble()
        {
            InitializeGeneratedDoubles();
            double num;
            do
            {
                if (generatedDoubles.Count == int.MaxValue) { NoPossibleNumber?.Invoke(this, System.EventArgs.Empty); return -1; }
                num = random.NextDouble();
            } while (generatedDoubles.Contains(num));
            generatedDoubles.Add(num);
            return num;
        }

        void InitializeGeneratedInts()
        {
            if (generatedInts == null) generatedInts = new System.Collections.Generic.List<int>();
        }

        void InitializeGeneratedDoubles()
        {
            if (generatedDoubles == null) generatedDoubles = new System.Collections.Generic.List<double>();
        }

        void Clear()
        {
            generatedInts = null;
            generatedDoubles = null;
        }

        public void Reset()
        {
            random = new System.Random();
            Clear();
        }

        public void Reset(int Seed)
        {
            random = new System.Random(Seed);
            Clear();
        }
    }
}
