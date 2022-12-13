using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_SS_71
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte yüzde;
            try
            {
                yüzde = Convert.ToByte(textBox1.Text);
                progressBar1.Value = yüzde;
            }
            catch (Exception)
            {

                MessageBox.Show("lütfen 0 ve 100 arası bir değer giriniz");
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
