﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg22
{
    public partial class Form1 : Form
    {
        ArrayList kaynakVeri = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitaplar kitap = new Kitaplar();
            kitap.KitapAdi = textBox1.Text;
            kitap.KitapTuru = textBox2.Text;
            kitap.KitapYazari = textBox3.Text;
            kaynakVeri.Add(kitap);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = kaynakVeri;
            listBox1.DisplayMember = "KitapAdi";
        }
    }
}
