using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace KutuphaneProjesi
{
    public partial class FormOgrenci : Form
    {
        public FormOgrenci()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri vtislemleri = new VeriTabaniIslemleri();
        MySqlConnection baglanti;
        string komutsatiri;
        

        private void FormOgrenci_Load(object sender, EventArgs e)
        {
            listele();
        }
        public void listele()
        {
            baglanti = vtislemleri.baglan();
            komutsatiri = "Select * From ogrenciler";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutsatiri, baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            gridOgrenci.DataSource = dataTable;
            gridOgrenci.Columns
            gridOgrenci.Columns
            gridOgrenci.Columns
            gridOgrenci.Columns
        }
    }
}
