using System;
using System.IO;
using System.Windows.Forms;

namespace SFDTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            sfd.Title = "Odaberite lokaciju";
            sfd.InitialDirectory = @"C:\";
            sfd.CheckFileExists = true;
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                using (var sw = new StreamWriter(sfd.FileName))
                {
                    sw.WriteLineAsync(textBox1.Text);
                }
            }
        }
    }
}
