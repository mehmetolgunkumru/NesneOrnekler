using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ErrorProvider ep = new ErrorProvider();
        private void txtNumara_Validating(object sender, CancelEventArgs e)
        {
            int sonuc;
            if (int.TryParse(txtNumara.Text,out sonuc))
            {
                ep.SetError(txtNumara, "");
            }
            else
            {
                e.Cancel = true;
                ep.SetError(txtNumara, "Numara Girişi Hatalı...");
            }
        }

        private void txAd_Validating(object sender, CancelEventArgs e)
        {
            if (txAd.Text == "")
            {
                e.Cancel = true;
                ep.SetError(txAd, "Ad Soyad Giriniz...");
            }
            else
            {
                ep.SetError(txAd,"");
            }
        }

        private void txtDersNotu_Validating(object sender, CancelEventArgs e)
        {
            int dersNotu;
            if (int.TryParse(txtDersNotu.Text, out dersNotu)) 
            {
                if (dersNotu < 0 || dersNotu > 100)
                {
                    e.Cancel = true;
                    ep.SetError(txtDersNotu, "0 - 100 arasında değer giriniz.");
                }
                else
                {
                    ep.SetError(txtDersNotu, "");
                }
            }
            else
            {
                e.Cancel = true;
                ep.SetError(txtDersNotu, "Sayısal Değer Giriniz..");
            }
        }
    }
}
