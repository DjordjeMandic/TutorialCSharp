using System;
using System.IO;
using System.Windows.Forms;

namespace StreamWriterTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string lokacija;
        private void button1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                button2.Enabled = true;
                lokacija = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var sw = new StreamWriter(File.Create(lokacija)))
                {
                    sw.BaseStream.Position = 0xE5;
                    /*sw.BaseStream.WriteByte(0x4C);*/
                    byte[] bajtovi = { 0x55, 0x3E, 0xFF, 0x9A };
                    sw.BaseStream.Write(bajtovi, 3, 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
