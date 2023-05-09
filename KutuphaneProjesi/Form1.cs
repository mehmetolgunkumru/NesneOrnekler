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
    public partial class formAnaSayfa : Form
    {
        public formAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnKıtap_Click(object sender, EventArgs e)
        {
            FormKitap kitap = new FormKitap();
            kitap.ShowDialog();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            FormOgrenci ogrenci = new FormOgrenci();
            ogrenci.ShowDialog();
        }

        private void btnTur_Click(object sender, EventArgs e)
        {
            FormKitapTur kitapTur = new FormKitapTur();
            kitapTur.ShowDialog();
        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {
            FormOduncKitap oduncKitap = new FormOduncKitap();
            oduncKitap.ShowDialog();
        }
    }
}
