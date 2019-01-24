using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace OFDTutorial
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //podesavamo dialog pre otvaranja
            ofd.Filter = "Bilo Koji Fajl|*.*|DLL Fajl (*.dll)|*.dll|EXE Fajl (*.exe)|*.exe"; // "(Ime)|(tipfajla - *.blabla)|(Ime)|(tipfajla - *.blabla)|(Ime)|(tipfajla - *.blabla)"
            ofd.FilterIndex = 3;
            ofd.Title = "Odaberite neki fajl";
            ofd.InitialDirectory = @"G:\Riot Games\PBE";
            ofd.ShowHelp = true;
            ofd.Multiselect = true;
            ofd.HelpRequest += pritisnutJeHelp;
            ofd.FileOk += fajlJeOK;


            //otvaramo dialog
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("Pritisnuto je ok");
                Console.WriteLine(ofd.FileName);
                Console.WriteLine(ofd.SafeFileName);
                foreach(string filename in ofd.FileNames)
                {
                    Console.WriteLine(filename);
                }
                foreach (string safefilename in ofd.SafeFileNames)
                {
                    Console.WriteLine(safefilename);
                }
            }
            else
            {
                Console.WriteLine("Nije pritisnuto ok");
            }

            void pritisnutJeHelp(object sender, EventArgs e)
            {
                MessageBox.Show("Pritisnut je help");
            }

            void fajlJeOK(object sender, CancelEventArgs e)
            {
                MessageBox.Show("Fajl je OK");
            }
        }
    }
}
