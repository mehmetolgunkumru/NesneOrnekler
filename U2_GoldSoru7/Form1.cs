using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int rsayi = 0, x;
            for (x = 0; x < 100; x++)
            {

                rsayi = r.Next(1, 100);
                ListBox1.Items.Add(rsayi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int enBuyuk = Convert.ToInt32(ListBox1.Items[0]), sayi;
            for (int i = 0; i < ListBox1.Items.Count; i++)
            {
                sayi = Convert.ToInt32(ListBox1.Items[i]);
                if (sayi > enBuyuk)
                {
                    enBuyuk = sayi;
                }
            }
            label3.Text = "Listedeki En Büyük Sayı =" + enBuyuk.ToString();

            int enkucuk = Convert.ToInt32(ListBox1.Items[0]), sayı;
            for (int i = 0; i < ListBox1.Items.Count; i++)
            {
                sayı = Convert.ToInt32(ListBox1.Items[i]);
                if (sayı < enkucuk) 
                {
                    enkucuk = sayı;
                }
                label4.Text = "Listedeki En Küçük Sayı=" + enkucuk.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            Random r = new Random();
            int rsayı = 0; 

            }
    }
}










