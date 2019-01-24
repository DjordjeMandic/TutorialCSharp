using System;
using System.Windows.Forms;

namespace ConvertClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte a = 128;
                int b = a;

                int c = 256;
                byte d = (byte)c;


                UInt64 br64 = 4294967296;
                int br32 = (int)br64;

                MessageBox.Show(br32.ToString());
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("ArgumentNullException: Morate proslediti neke podatke");
            }
            catch (FormatException)
            {
                MessageBox.Show("FormatException: UInt32 se moze dobiti samo iz brojeva");
            }
            catch (OverflowException)
            {
                MessageBox.Show("OverflowException: UInt32 Ne moze biti negativan");
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Kastovanje neuspenso");
            }
            catch
            {
                MessageBox.Show("Konverzija Neuspesna");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
