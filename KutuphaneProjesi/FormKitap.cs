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
    public partial class FormKitap : Form
    {
        public FormKitap()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri vtislemleri = new VeriTabaniIslemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        string komutsatiri;
        private void FormKitap_Load(object sender, EventArgs e)
        {
            KitapTurYukle();
            KitapListele();
                
        }

        private void KitapListele()
        {
            try
            {
                baglanti = vtislemleri.baglan();
                komutsatiri = "Select * From kitap_turleri";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutsatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                comboKitapTur.DataSource = dataTable;
                comboKitapTur.ValueMember = "tur_id";
                comboKitapTur.DisplayMember = "tur_adi";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KitapTurYukle()
        {
            try
            {
                baglanti = vtislemleri.baglan();
                komutsatiri = "Select kitap_id, tur_adi, kitap_adi, yazar, yayinevi, sayfa_sayisi From kitaplar, kitap_turleri where kitaplar.tur_id=kitap_turleri.tur_id";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutsatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridKitap.DataSource = dataTable;
                gridKitap.Columns["kitap_id"].HeaderText = "ID";
                gridKitap.Columns["kitap_id"].Width = 20;
                gridKitap.Columns["tur_adi"].HeaderText = "Tür";
                gridKitap.Columns["tur_adi"].Width = 30;
                gridKitap.Columns["Kitap_adi"].HeaderText = "Adı";
                gridKitap.Columns["kitap_adi"].Width = 90;
                gridKitap.Columns["yazar"].HeaderText = "Yazar";
                gridKitap.Columns["yazar"].Width = 80 ;
                gridKitap.Columns["yayinevi"].HeaderText = "Yayın Evi";
                gridKitap.Columns["yayinevi"].Width = 80 ;
                gridKitap.Columns["sayfa_sayisi"].HeaderText = "Sayfa Sayısı";
                gridKitap.Columns["sayfa_sayisi"].Width = 50 ;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komut = new MySqlCommand(komutsatiri, baglanti);
                komut.Connection = baglanti;
                komut.CommandText = "Insert Into kitaplar (tur_id,kitap_adi,yazar,yayinevi,sayfa_sayisi)" +
                    "Values (@tur_id,@kitap_adi,@yazar,@yayinevi,@sayfa_sayisi";
                komut.Parameters.AddWithValue("@tur_id", int.Parse(comboKitapTur.SelectedValue.ToString()));
                komut.Parameters.AddWithValue("@kitap_adi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
                komut.Parameters.AddWithValue("@yayinevi",txtYayinEvi .Text);
                komut.Parameters.AddWithValue("@sayfa_sayisi",txtSayfaSayisi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                KitapListele();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            txtKitapAdi.Clear();
            txtSayfaSayisi.Clear();
            txtYayinEvi.Clear();
            txtYazar.Clear();
        }

        private void gridKitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtKitapAdi.Text = gridKitap.CurrentRow.Cells["Kitap_adi"].Value.ToString();
                txtSayfaSayisi.Text = gridKitap.CurrentRow.Cells["sayfa_sayisi"].Value.ToString();
                txtYayinEvi.Text = gridKitap.CurrentRow.Cells["yayinevi"].Value.ToString();
                txtYazar.Text = gridKitap.CurrentRow.Cells["yazar"].Value.ToString();
                comboKitapTur.Text = gridKitap.CurrentRow.Cells["tur_adi"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutsatiri = "DELETE FROM kitaplar WHERE kitap_id = @kitap_id";
                komut = new MySqlCommand(komutsatiri, baglanti);
                komut.Parameters.AddWithValue("@kitap_id", int.Parse(gridKitap.CurrentRow.Cells["@kitap_id"].Value.ToString()));
                komut.ExecuteNonQuery();
                baglanti.Close();
               Temizle();
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
               KitapListele();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komut = new MySqlCommand(komutsatiri, baglanti);
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE kitaplar SET tur_id=@tur_id, kitap_adi=@kitap_adı," +
                    "yazar=@yazar, yayinevi=@yayinevi,sayfa_sayisi=@sayfa_sayisi where kitap_id=@kitap_id ";

                komut.Parameters.AddWithValue("@Kitap_id", int.Parse(gridKitap.CurrentRow.Cells["Kitap_id"].Value.ToString()));
                komut.Parameters.AddWithValue("@tur_id", int.Parse(comboKitapTur.SelectedValue.ToString()));
                komut.Parameters.AddWithValue("@Kitap_adi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayinEvi.Text);
                komut.Parameters.AddWithValue("@sayfa_sayisi", int.Parse(txtSayfaSayisi.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                KitapListele();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            KitapArama(txtKitapAra.Text);
        }

        private void KitapArama(string text)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
