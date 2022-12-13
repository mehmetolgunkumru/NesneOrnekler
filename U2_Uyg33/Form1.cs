using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Uyg33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Giris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi;

            long parola;

            try
            {
                kullaniciAdi = txtkuladi.Text.ToString();                parola = long.Parse(txtsifre.Text.ToString());

                MessageBox.Show("Giriş Başarılı.Hoşgeldiniz " +kullaniciAdi);

            }
            catch (Exception)
            {

                MessageBox.Show("Şifreniz Sadece Sayılardan Oluşmalıdır.Tekrar Deneyiniz.");                txtsifre.Text = "";
            }

        }
    }
    }
