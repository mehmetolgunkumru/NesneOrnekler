using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5];
        int[] notlar = new int[5];
        int index = 0;               
        private void btnAd_Click(object sender, EventArgs e)
        {
            if (index < isimler.Length)
            {
                isimler[index] = textBox1.Text;
                notlar[index] = int.Parse(textBox2.Text);
                index++;
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i] != null) ;
                {
                    listBox1.Items.Add(isimler[i] + "=>" + notlar[i]);
                }
            }
        }

        private void btnBüyük_Click(object sender, EventArgs e)
        {
            int enbuyuk = 0;
            for (int i = 0; i < notlar.Length; i++)
            {
                if(enbuyuk<notlar[i])
                {
                    enbuyuk = notlar[i];
                }
            }
            textBox3.Text = enbuyuk.ToString();
        }

        private void btnOrta_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            double ortalama = 0;
            for (int i = 0; i < notlar.Length; i++)
            {
                toplam += notlar[i];
            }
            ortalama = toplam / notlar.Length;
            textBox5.Text = ortalama.ToString();
        }

        private void btnKüçük_Click(object sender, EventArgs e)
        {
            int enkucuk = 0;
            for (int i = 0; i < notlar.Length; i++)
            {
                if (enkucuk > notlar[i])
                {
                    enkucuk = notlar[i];
                }
            }
            textBox4.Text = enkucuk.ToString();
        }
    }
}
