using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class FormKitap : Form
    {
        public FormKitap()
        {
            InitializeComponent();
        }

        private void FormKitap_Load(object sender, EventArgs e)
        {
            VeriTabaniIslemleri vtislemleri = new VeriTabaniIslemleri();
            MySqlConnection baglanti;
            MySqlCommand komut;
            string komutsatiri;
        }
    }
}
