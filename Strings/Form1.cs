using System;
using System.Windows.Forms;

namespace Strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string Osoba = "                         Ana Markovic             ";
            /*string Ime = Osoba.Substring(0, 4); // substring(int startIndex, int lenght) cita od startIndex i naredni broj karaktera unesen u lenght
            string Prezime = Osoba.Substring(5, 5);
            string PrezimeBezLenght = Osoba.Substring(5); // substring(int startIndex) cita od startIndex do kraja stringa
            MessageBox.Show(Prezime);*/
            /*string Ime = Osoba.Substring(0, Osoba.IndexOf(' '));
            MessageBox.Show(Ime);
            string Prezime = Osoba.Substring(Osoba.IndexOf(' ') + 1);
            MessageBox.Show(Prezime);*/

            //Osoba = Osoba.TrimEnd();

            // trim brise sve razmake na pocetku i na kraju stringa i vraca string
            // trimstart brise sve razmake na pocektu i vraca string
            // trimend brise sve razmake na kraju i vraca string
            // indexOf nam daje lokaciju zeljenog karaktera. (na koji prvi naleti)

            //MessageBox.Show(Osoba);

            /*string recenica = "Zdravo, ja sam Milica. Zdravo Zdravo zdravo";
            string prepravljeno = recenica.Replace('a', 'A');
            MessageBox.Show(prepravljeno);*/


            /*string imena = "Marko|Milica|Sandra|Bojan";
            string[] arrayImena = imena.Split('|');
            foreach (string s in arrayImena) MessageBox.Show(s);*/

            string brojevi = "Srdjan";
            char[] arrayKaraktera = brojevi.ToCharArray();
            foreach (char c in arrayKaraktera) MessageBox.Show(c.ToString());
        }
    }
}
