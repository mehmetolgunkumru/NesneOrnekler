using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] dizi;
        int SatirSayisi;
        int SutunSayisi;
        private void btnOluştur_Click(object sender, EventArgs e)
        {
            int rastgeleMin = int.Parse(textBox3.Text);
            int rastgeleMax = int.Parse(textBox4.Text);
            SatirSayisi = int.Parse(textBox2.Text);
            SutunSayisi = int.Parse(textBox1.Text);
            dizi = new int[SatirSayisi, SutunSayisi];
            Random rastgele = new Random();
            for (int x = 0; x < SatirSayisi; x++)
            {
                for (int y = 0; y < SutunSayisi; y++)
                {
                    dizi[x, y] = rastgele.Next(rastgeleMin, rastgeleMax);
                }
            }
        }
    }
}
