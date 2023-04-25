using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_SS_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler;
        int[,] notlar;
        int index = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            isimler[index] = textBox1.Text;
            notlar[index, 0] = int.Parse(txtSozlu1.Text);
            notlar[index, 1] = int.Parse(txtSozlu2.Text);
            notlar[index, 2] = int.Parse(txtYazili1.Text);
            notlar[index, 3] = int.Parse(txtYazili2.Text);
            index++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Ogrsayisi = int.Parse(txtOgrSayisi.Text);
            isimler = new string[Ogrsayisi];
            notlar = new int[Ogrsayisi, 4];
        }
    }
}
