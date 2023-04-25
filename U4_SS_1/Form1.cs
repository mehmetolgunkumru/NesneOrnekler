using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_SS_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5];
        int index = 0;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                isimler[index] = textBox1.Text;
                index++;
                textBox1.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("yavaşşş");
            }
        }

        private void btnSırala_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string isim in isimler)
                {
                    listBox1.Items.Add(isim);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("eksik eleman");
            }

        }
    }
}
