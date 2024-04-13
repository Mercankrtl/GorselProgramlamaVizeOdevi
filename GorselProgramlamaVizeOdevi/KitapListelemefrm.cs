using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaVizeOdevi
{
    public partial class KitapListelemefrm : Form
    {
        private DataTable dtkitaplar;
        private SQLiteConnection baglanti;

        public KitapListelemefrm()
        {
            InitializeComponent();

            // Veritabanı bağlantısı oluşturuluyor
            baglanti = new SQLiteConnection("Data Source=kitaplar.db;Version=3;");
            baglanti.Open();

            // DataTable oluşturuluyor
            dtkitaplar = new DataTable();
            dtkitaplar.Columns.Add("K.BarkodNo");
            dtkitaplar.Columns.Add("KitapAdi");
            dtkitaplar.Columns.Add("Yazari");
            dtkitaplar.Columns.Add("YayinEvi");
            dtkitaplar.Columns.Add("SayfaNo", typeof(int));
            dtkitaplar.Columns.Add("Turu");
            dtkitaplar.Columns.Add("RafNo");

            // DataGridView veri kaynağı olarak DataTable ayarlanıyor
            dgvkitaplar.DataSource = dtkitaplar;

            // Veritabanı bağlantısı kapatılıyor
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Kitap ekleme formunu aç
            KitapEkleForm kitapEkleForm = new KitapEkleForm();
            kitapEkleForm.ShowDialog();

            // Kitap eklendiyse DataGridView'e ekle
            if (kitapEkleForm.DialogResult == DialogResult.OK)
            {
                DataRow row = dtkitaplar.NewRow();
                row["K.BarkodNo"] = kitapEkleForm.txtBarkodNo.Text;
                row["KitapAdi"] = kitapEkleForm.txtKitapAdi.Text;
                row["Yazari"] = kitapEkleForm.txtYazari.Text;
                row["YayinEvi"] = kitapEkleForm.txtYayinEvi.Text;
                row["SayfaNo"] = Convert.ToInt32(kitapEkleForm.txtSayfaNo.Text);
                row["Turu"] = kitapEkleForm.txtTuru.Text;
                row["RafNo"] = kitapEkleForm.txtRafNo.Text;
                dtkitaplar.Rows.Add(row);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            // Formu kapat
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Seçili satırı sil
            foreach (DataGridViewRow row in dgvkitaplar.SelectedRows)
            {
                int barkodNo = Convert.ToInt32(row.Cells["K.BarkodNo"].Value);

                // Veritabanı bağlantısını aç
                baglanti.Open();

                // Kitap kaydını veritabanından sil
                SQLiteCommand komut = new SQLiteCommand("DELETE FROM kitaplar WHERE BarkodNo=@barkodNo", baglanti);
                komut.Parameters.AddWithValue("@barkodNo", barkodNo);
                komut.ExecuteNonQuery();

                // Veritabanı bağlantısını kapat
                baglanti.Close();

                dgvkitaplar.Rows.Remove(row);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Seçili satırı güncelle
            foreach (DataGridViewRow row in dgvkitaplar.SelectedRows)
            {
                int barkodNo = Convert.ToInt32(row.Cells["K.BarkodNo"].Value);

                // Kitap güncelleme formunu aç
                KitapGuncelleForm kitapGuncelleForm = new KitapGuncelleForm(barkodNo);
                kitapGuncelleForm.ShowDialog();

                // Kitap güncellendiyse DataGridView'i güncelle
                if (kitapGuncelleForm.DialogResult == DialogResult.OK)
                {
                    row.Cells["KitapAdi"].Value = kitapGuncelleForm.txtKitapAdi.Text;
                    row.Cells["Yazari"].Value = kitapGuncelleForm.txtYazari.Text;
                    row.Cells["YayinEvi"].Value = kitapGuncelleForm.txtYayinEvi.Text;
                    row.Cells["SayfaNo"].Value = Convert.ToInt32(kitapGuncelleForm.txtSayfaNo.Text);
                    row.Cells["Turu"].Value = kitapGuncelleForm.txtTuru.Text;
                    row.Cells["RafNo"].Value = kitapGuncelleForm.txtRafNo.Text;
                }
            }
        }
    }
}