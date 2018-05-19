using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace ConsoleClass
{
    internal class Program
    {
        private static List<byte[]> list = new List<byte[]>();

        private static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(test));
            Thread t1 = new Thread(new ThreadStart(test));
            Thread t2 = new Thread(new ThreadStart(test));
            Thread t3 = new Thread(new ThreadStart(test));
            t.Start();
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }

        private static void test()
        {
            ConsumeCPU(0);
        }

        public static void ConsumeCPU(int percentage)
        {
            if (percentage < 0 || percentage > 100)
                throw new ArgumentException("percentage");
            Stopwatch watch = new Stopwatch();
            watch.Start();
            while (true)
            {
                // Make the loop go on for "percentage" milliseconds then sleep the
                // remaining percentage milliseconds. So 40% utilization means work 40ms and sleep 60ms
                if (watch.ElapsedMilliseconds > percentage)
                {
                    Thread.Sleep(100 - percentage);
                    watch.Reset();
                    watch.Start();
                }
            }
        }

        private static void Epizoda6()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("asdkhbnaslkj.d,bnasjkdba sduhjkasd");
            }
            Console.ReadLine();
            Console.Clear();
            Console.ReadLine();
        }

        private static void Epizoda5()
        {
            Console.CancelKeyPress += new ConsoleCancelEventHandler(nasCancelEvent);
            while (true)
            {
            }
        }

        protected static void nasCancelEvent(object posaljilac, ConsoleCancelEventArgs args)
        {
            Console.WriteLine("Pritisnuli smo ctrl c i konzola nece izaci");
            args.Cancel = true;
        }

        private static void Epizoda4()
        {
            Tetris();
            Console.ReadLine();
            SuperMario();
            Console.ReadLine();
        }

        private static void Epizoda3()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Title = "Ja sam konzola";

            Console.BackgroundColor = ConsoleColor.Yellow; // pozadinska boja
            Console.ForegroundColor = ConsoleColor.Black; // boja teksta

            Console.WriteLine("crno");

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("‼ ú ê ♣ ╘ Ñ ○ h ç *");
            Console.ReadLine();

            Console.ResetColor();

            Console.WriteLine("Normalna Konzola.");
            Console.ReadLine();

            Console.CursorVisible = false;
            Console.ReadLine();
            Console.WriteLine(Console.WindowHeight);
            Console.WriteLine(Console.WindowWidth);
            Console.ReadLine();
            Console.WriteLine(Console.BufferHeight);
            Console.WriteLine(Console.BufferWidth);
            Console.ReadLine();
            Console.WriteLine(Console.LargestWindowHeight);
            Console.WriteLine(Console.LargestWindowWidth);
            Console.ReadLine();
            Console.SetCursorPosition(15, 20);
            Console.WriteLine("Tekst koji pocinje sa lokacije 15,20");
            Console.ReadLine();
        }

        private static void Epizoda2()
        {
            #region read

            /*int procitano;
            while ((procitano = Console.Read()) != 0)
            {
                Console.WriteLine(procitano + " = " + Convert.ToChar(procitano));
            }*/

            #endregion read

            #region readkey

            /*switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Home:
                    Console.WriteLine("Pritisnuo si home");
                    break;

                case ConsoleKey.End:
                    Console.WriteLine("Pritisnuo si end");
                    break;

                case ConsoleKey.Insert:
                    Console.WriteLine("Pritisnuo si insert");
                    break;

                case ConsoleKey.Delete:
                    Console.WriteLine("Pritisnuo si delete");
                    break;

                case ConsoleKey.PageUp:
                    Console.WriteLine("Pritisnuo si pgup");
                    break;

                case ConsoleKey.PageDown:
                    Console.WriteLine("Pritisnuo si pgdw");
                    break;

                default:
                    Console.WriteLine("Pritisnuo si nesto drugo");
                    break;
            }*/

            #endregion readkey

            #region readline

            /*switch(Console.ReadLine())
            {
                case "pgup":
                    Console.WriteLine("page up");
                    break;

                case "pgdw":
                    Console.WriteLine("page down");
                    break;

                default:
                    Console.WriteLine("Napisi pgup ili pgdw");
                    break;
            }*/

            #endregion readline

            int read = Console.Read(); // 49 || KeyCode
            ConsoleKey consoleKey = Console.ReadKey().Key; // Enum
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(); // Struct
            char readKeyChar = Console.ReadKey().KeyChar; // 'a'
            string readLine = Console.ReadLine(); // "abc"
        }

        private static void Epizoda1()
        {
            //Console.WriteLine("1") = Console.Write("1") + Console.WriteLine()

            //Console.Write("1");
            Console.WriteLine("1");
            //Console.Write("2");
            Console.WriteLine("2");
        }

        #region Melodije

        private static void Tetris()
        {
            Console.Beep(658, 125);
            Console.Beep(1320, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 250);
            Console.Beep(1320, 125);
            Console.Beep(1188, 125);
            Console.Beep(1056, 250);
            Console.Beep(990, 250);
            Console.Beep(880, 500);
            Console.Beep(880, 250);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 750);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(250);
            Console.Beep(1188, 500);
            Console.Beep(1408, 250);
            Console.Beep(1760, 500);
            Console.Beep(1584, 250);
            Console.Beep(1408, 250);
            Console.Beep(1320, 750);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(500);
            Console.Beep(1320, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 250);
            Console.Beep(1320, 125);
            Console.Beep(1188, 125);
            Console.Beep(1056, 250);
            Console.Beep(990, 250);
            Console.Beep(880, 500);
            Console.Beep(880, 250);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 750);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(250);
            Console.Beep(1188, 500);
            Console.Beep(1408, 250);
            Console.Beep(1760, 500);
            Console.Beep(1584, 250);
            Console.Beep(1408, 250);
            Console.Beep(1320, 750);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(500);
        }

        private static void SuperMario()
        {
            Console.Beep(659, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(523, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Thread.Sleep(375);
            Console.Beep(392, 125);
            Thread.Sleep(375);
            Console.Beep(523, 125);
            Thread.Sleep(250);
            Console.Beep(392, 125);
            Thread.Sleep(250);
            Console.Beep(330, 125);
            Thread.Sleep(250);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(494, 125);
            Thread.Sleep(125);
            Console.Beep(466, 125);
            Thread.Sleep(42);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(392, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Thread.Sleep(125);
            Console.Beep(880, 125);
            Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(784, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(587, 125);
            Console.Beep(494, 125);
            Thread.Sleep(125);
            Console.Beep(523, 125);
            Thread.Sleep(250);
            Console.Beep(392, 125);
            Thread.Sleep(250);
            Console.Beep(330, 125);
            Thread.Sleep(250);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(494, 125);
            Thread.Sleep(125);
            Console.Beep(466, 125);
            Thread.Sleep(42);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(392, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Thread.Sleep(125);
            Console.Beep(880, 125);
            Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(784, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(587, 125);
            Console.Beep(494, 125);
            Thread.Sleep(375);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(698, 125);
            Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(698, 125);
            Thread.Sleep(625);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(622, 125);
            Thread.Sleep(250);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(523, 125);
            Thread.Sleep(1125);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(698, 125);
            Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(698, 125);
            Thread.Sleep(625);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(622, 125);
            Thread.Sleep(250);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(523, 125);
            Thread.Sleep(625);
        }

        #endregion Melodije
    }
}