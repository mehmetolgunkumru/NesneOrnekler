﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);
            int sonuc;

            if (rbToplama.Checked == true)
            {
                sonuc = sayi1 + sayi2;
            }
            else
            {
                sonuc = sayi1 * sayi2;
            }

            label4.Text = sonuc.ToString();
        }
    }
}
