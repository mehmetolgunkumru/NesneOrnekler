using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg24
{
    public partial class Form1 : Form
    {
        List<Ogrenciler> Liste = new List<Ogrenciler>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Numara = int.Parse(txtNumara.Text);
            ogrenci.AdSoyad = txtAdSoyad.Text;
            ogrenci.DersNotu = int.Parse(txtDersNotu.Text);
            Liste.Add(ogrenci);
            Bagla();
        }

        private void Bagla()
        {
            GridListe.DataSource = null;
            GridListe.DataSource = Liste;
        }

        private void GridListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumara.Text = GridListe.CurrentRow.Cells[0].Value.ToString();
            txtAdSoyad.Text = GridListe.CurrentRow.Cells[1].Value.ToString();
            txtDersNotu.Text = GridListe.CurrentRow.Cells[2].Value.ToString();

        }
    }
}
