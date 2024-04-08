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
        DataTable dtkitaplar;

        public KitapListelemefrm()
        {
            InitializeComponent();

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
                dgvkitaplar.Rows.Remove(row);
            }
        }
    }
}
