using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace EP43
{
    class Program
    {


        static void Main(string[] args)
        {
            WriteText();
        }

        static void NapraviFajl()
        {
            File.Create(@"C:/NasFajl.txt").Close();
        }

        static void OrbisiFajl()
        {
            File.Delete(@"C:/NasFajl.txt");
        }

        static void PremestiFajl()
        {
            File.Move(@"C:/NasFajl.txt", "C:/NasFolder/NasFajl123.txt");
        }

        static void KopirajFajl()
        {
            File.Copy(@"C:/debug.log", @"C:/BlaBla.txt", true);
        }

        static void PostojiFajl()
        {
            Console.WriteLine(File.Exists(@"C:/debug.log"));
            Console.WriteLine(File.Exists(@"C:/BlaBla.txt"));
        }

        static void WriteText()
        {
            var stringarray = new string[] { "123", "a", "ko si ti" };

            File.AppendAllLines(@"C:/nastextfajl.txt", stringarray);
            File.WriteAllText(@"C:/nastextfajl123.txt", "123123123123");
        }
    }
}
