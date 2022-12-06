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
        private readonly string textBox_KullaniciAdi;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kulanıcıadı;
            long parola;
            try
            {
                kulanıcıadı = textBox_KullaniciAdi
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
