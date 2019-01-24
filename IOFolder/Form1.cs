using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IOFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.Description = "Obrisi folder.";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Directory.Move(fbd.SelectedPath, Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), new DirectoryInfo(fbd.SelectedPath).Name));
            }
            else
            {
                MessageBox.Show("Nije odabran folder.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
