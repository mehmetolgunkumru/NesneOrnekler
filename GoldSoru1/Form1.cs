using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldSoru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int[] ortalamalar = new int[30];

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                ortalamalar[i] = random.Next(101);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                listBox1.Items.Add(ortalamalar[i]);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                if (ortalamalar[i] < 50) 
                {
                    listBox1.Items.Add(ortalamalar[i]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                if (ortalamalar[i] > 70 && ortalamalar[i] < 100) 
                {
                    listBox1.Items.Add(ortalamalar[i]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Clear();
            int toplam = 0;
            int ortalama = 0;
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                toplam += ortalamalar[i];
            }
            ortalama = toplam / ortalamalar.Length;
            listBox1.Items.Add(ortalama);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int yuksek = ortalamalar[0];
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                if (yuksek < ortalamalar[i]) 
                {
                    yuksek = ortalamalar[i];
                }
            }
            label1.Text = "En Yüksek Not: " + yuksek.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int dusuk = ortalamalar[0];
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                if (dusuk > ortalamalar[i])
                {
                    dusuk = ortalamalar[i];
                }
            }
            label1.Text = "En Düşük Not: " + dusuk.ToString();
        }
        int gecensayisi;
        int kalansayisi;

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                if (ortalamalar[i] >= 50)
                {
                    gecensayisi++;
                }
            }
            label1.Text = "Geçen Sayısı: " + gecensayisi.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            kalansayisi = 0;
            listBox1.Items.Clear();
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                if (ortalamalar[i] < 50)d