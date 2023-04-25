using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                txtBilgi.Text = "";
                txtBilgi.Text += txtAdSoyad.Text + "\r\n";
                txtBilgi.Text += txtTelefon.Text + "\r\n";
                txtBilgi.Text += txtAdres.Text + "\r\n";
                decimal hesap = 0;
                if (nCorba.Value > 0)
                {
                    hesap += nCorba.Value * 35;
                    txtBilgi.Text += string.Format("Çorba {0:C}",nCorba.Value * 35) + "\r\n";
                }
                txtBilgi.Text += "-----------------";
                txtBilgi.Text += string.Format("Toplam {0:C}", hesap);

                
                
                if (nSalata.Value > 0)
                {
                    hesap += nSalata.Value * 25;
                    txtBilgi.Text += string.Format("Salata {0:C}", nSalata.Value * 25) + "\r\n";
                }
                txtBilgi.Text += "-----------------";
                txtBilgi.Text += string.Format("Toplam {0:C}", hesap);

               
                
                if (nAnaYemek.Value > 0)
                {
                    hesap += nAnaYemek.Value * 75;
                    txtBilgi.Text += string.Format("Ana Yemek {0:C}", nAnaYemek.Value * 75) + "\r\n";
                }
                txtBilgi.Text += "-----------------";
                txtBilgi.Text += string.Format("Toplam {0:C}", hesap);

                
                
                if (nTatlı.Value > 0)
                {
                    hesap += nTatlı.Value * 40;
                    txtBilgi.Text += string.Format("Tatlı {0:C}", nTatlı.Value * 40) + "\r\n";
                }
                txtBilgi.Text += "-----------------";
                txtBilgi.Text += string.Format("Toplam {0:C}", hesap);
            }
        }
    }
}
