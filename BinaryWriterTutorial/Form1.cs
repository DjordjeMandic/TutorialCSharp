using System;
using System.IO;
using System.Windows.Forms;

namespace BinaryWriterTutorial
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
                using (var bw = new BinaryWriter(File.Create(lokacija)))
                {
                    int a = 516153513;
                    byte[] buffer = BitConverter.GetBytes(a);
                    Array.Reverse(buffer);
                    int okrenutiA = BitConverter.ToInt32(buffer, 0);
                    bw.Write(okrenutiA);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
