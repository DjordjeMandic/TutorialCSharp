using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EP41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowOpenFolderDialogButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = textBox1.Text;
                fbd.ShowNewFolderButton = checkBox1.Checked;
                fbd.RootFolder = Environment.SpecialFolder.ApplicationData;
                fbd.HelpRequest += Fbd_HelpRequest;

                var rslt = fbd.ShowDialog();

                if(rslt == DialogResult.OK)
                {
                    label1.Text = fbd.SelectedPath;
                }
                else if(rslt == DialogResult.Cancel)
                {
                    label1.Text = "Korisnik je odustao od odabira foldera";
                }
                else
                {
                    label1.Text = "Dialog izasao na cudan nacin...";
                }

                fbd.Reset();

                fbd.ShowDialog();
            }
        }

        private void Fbd_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Help dugme je pritisnuto, nadji paceniku dokumentaciju kako kmoristiti fbd.");
            //Process.start(neki url koji vodi ka helpu..masjokdbhasoijkdbnoajlsik)
        }
    }
}
