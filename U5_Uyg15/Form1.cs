using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(txtAd, "Adınızı Giriniz. ");
            tt.SetToolTip(txtSoyad, "Soyadını Giriniz. ");
            tt.SetToolTip(txtDt, "Doğum Tarihinizi gg/aa/yyyy Şeklinde Giriniz. ");
            tt.SetToolTip(txtAdres, "Adresinizi Giriniz.");

            tt.SetToolTip(btnKaydet, "Kaydetmek İçin Tıklayınız. ");
        }
    }
}
