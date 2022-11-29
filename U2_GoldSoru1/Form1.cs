using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi;
        int[] sayılar = new int[100];
        Random rndm = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int i = 0;
            while (i<10)
            {
                sayi = rndm.Next(1,100);
                int yoksa = Array.IndexOf(sayılar, sayi);
                if (yoksa==-1)
                {
                    sayılar[i] = sayi;
                    listBox1.Items.Add(sayi);
                    i++;
                }
              
            }
        }

        private void button2_Click(object sender, EventArgs e)

            {

            }
        }
    }
}
