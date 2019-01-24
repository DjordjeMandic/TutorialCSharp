using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Nasumicno
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var random = new Random();

            

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(random.Next()); // 0 - 2^32
                Console.WriteLine(random.Next(100)); // 0 - 100
                Console.WriteLine(random.Next(10, 20)); // 10 - 20

                Console.WriteLine(random.NextDouble()); // 0.0 - 1.0

                var buffer = new byte[10];
                random.NextBytes(buffer);
                Console.WriteLine(BitConverter.ToString(buffer));



                var karakteri = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
                string randomText = "";
                for (int a = 0; a < 35; a++)
                {
                    Console.WriteLine(a);
                    randomText += karakteri[random.Next(karakteri.Length - 1)]; // lenght = 3 || index {0 , 1 , 2}
                }
                Console.WriteLine(randomText);


                Console.WriteLine();
            }*/

            Console.WriteLine(BigMath.GetPi(500, 100000));
        }


        public static class BigMath
        {
            // digits = number of digits to calculate;
            // iterations = accuracy (higher the number the more accurate it will be and the longer it will take.)
            public static BigInteger GetPi(int digits, int iterations)
            {
                return 16 * ArcTan1OverX(5, digits).ElementAt(iterations)
                    - 4 * ArcTan1OverX(239, digits).ElementAt(iterations);
            }

            //arctan(x) = x - x^3/3 + x^5/5 - x^7/7 + x^9/9 - ...
            public static IEnumerable<BigInteger> ArcTan1OverX(int x, int digits)
            {
                var mag = BigInteger.Pow(10, digits);
                var sum = BigInteger.Zero;
                bool sign = true;
                for (int i = 1; ; i += 2)
                {
                    var cur = mag / (BigInteger.Pow(x, i) * i);
                    if (sign)
                    {
                        sum += cur;
                    }
                    else
                    {
                        sum -= cur;
                    }
                    yield return sum;
                    sign = !sign;
                }
            }
        }
    }
}
