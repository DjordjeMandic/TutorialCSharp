using System;
using System.IO;
using System.Windows.Forms;

namespace BinaryReaderTutorial
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
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                button2.Enabled = true;
                lokacija = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var br = new BinaryReader(File.OpenRead(lokacija)))
                {
                    br.BaseStream.Position = 0x01;
                    byte[] buffer = br.ReadBytes(4);
                    Array.Reverse(buffer);
                    int temp = BitConverter.ToInt32(buffer, 0);
                    textBox1.Text = temp.ToString() + "    " + temp.ToString("X");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
