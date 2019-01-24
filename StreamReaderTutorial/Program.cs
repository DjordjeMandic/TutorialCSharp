using System;
using System.IO; // potrebno za streamreader
using System.Windows.Forms;

namespace StreamReaderTutorial
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Textualni fajlovi (*.txt)|*.txt";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                /*Console.ReadKey();
                Console.Clear();*/
                try
                {
                    using (var sr = new StreamReader(ofd.FileName)) // koristimo streamreader dok ne zavrsimo i automatski se izbaci iz memorije
                    {
                        /*Console.WriteLine(sr.CurrentEncoding);
                        string linijaTexta;
                        while ((linijaTexta = sr.ReadLine()) != null) // citamo liniju po liniju i ispisujemo u konzolu dok ne dodjemo do kraja fajla
                        {
                            Console.WriteLine(linijaTexta);
                        }*/
                        /*sr.BaseStream.Position = 0;
                        byte[] buffer = new byte[5];
                        sr.BaseStream.Read(buffer, 0, 5);
                        string buffer2 = "";
                        foreach(byte mojByte in buffer)
                        {
                            buffer2 += mojByte.ToString("X") + ":";
                        }
                        Console.WriteLine(buffer2);*/
                        int c1 = sr.Peek();
                        int c2 = sr.Peek();

                        int c3 = sr.Read();
                        int c4 = sr.Read();

                        Console.WriteLine(c1.ToString("X"));
                        Console.WriteLine(c2.ToString("X"));
                        Console.WriteLine(c3.ToString("X"));
                        Console.WriteLine(c4.ToString("X"));

                        Console.WriteLine();

                        Console.WriteLine(c1.ToString("X") + " " + c2.ToString("X") + " " + c3.ToString("X") + " " + c4.ToString("X"));
                    }
                }
                catch(FileNotFoundException fileEx)
                {
                    Console.WriteLine("Fajl nije pronadjen, molimo proverite opet.");
                    Console.WriteLine("Lokacija fajla: " + fileEx.FileName);
                }
                catch(Exception e)
                {
                    Console.WriteLine("GRESKA:");
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
