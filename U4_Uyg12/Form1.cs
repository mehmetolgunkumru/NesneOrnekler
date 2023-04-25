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

namespace U4_Uyg12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList sehirler = new ArrayList();
        private void Listele()
        {
            listBox1.Items.Clear();
            foreach (string sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            sehirler.Add(textBox1.Text);
            Listele();
        }

        private void btnArayaEkle_Click(object sender, EventArgs e)
        {
            int indexNo = listBox1.SelectedIndex;
            sehirler.Insert(indexNo, textBox1.Text);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int indexNo = listBox1.SelectedIndex;
            sehirler[indexNo] = textBox1.Text;
            Listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int indexNo = listBox1.SelectedIndex;
            sehirler.RemoveAt(indexNo);
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (sehirler.Contains(textBox1.Text))
            {
                label1.Text = "Aranan Değer Bulundu.";
                listBox1.SelectedIndex = sehirler.IndexOf(textBox1.Text);
            }
            else
            {
                label1.Text = "Aranan Değer Bulunamadı.";
            }
        }
    }
}
