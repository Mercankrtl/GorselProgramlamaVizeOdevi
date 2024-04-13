using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace GorselProgramlamaVizeOdevi
{
    public partial class UyeListelemefrm : Form
    {
        private SQLiteConnection baglanti;

        public UyeListelemefrm()
        {
            InitializeComponent();
            baglanti = new SQLiteConnection("Data Source=uyeler.db;Version=3;");
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SQLiteCommand komut = new SQLiteCommand("INSERT INTO uyelisteleme(tc, ad, soyad, yas, cinsiyet, telefon, adres, email) VALUES(@tc, @ad, @soyad, @yas, @cinsiyet, @telefon, @adres, @email)", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTC.Text);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@yas", txtYas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", txtCinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);

            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Üye kaydı yapıldı");

            Temizle();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(dialog.FileName);
                List<Uye> uyeListesi = JsonConvert.DeserializeObject<List<Uye>>(json);
                foreach (Uye uye in uyeListesi)
                {
                    dataGridView1.Rows.Add(uye.Ad, uye.Soyad, uye.Email);
                }
                MessageBox.Show("Üye listesi yüklendi.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SQLiteCommand komut = new SQLiteCommand("UPDATE uyelisteleme SET ad=@ad, soyad=@soyad, yas=@yas, cinsiyet=@cinsiyet, telefon=@telefon, adres=@adres, email=@email WHERE tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTC.Text);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@yas", txtYas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", txtCinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);

            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Üye bilgileri güncellendi");

            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SQLiteCommand komut = new SQLiteCommand("DELETE FROM uyelisteleme WHERE tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTC.Text);

            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Üye kaydı silindi");

            Temizle();
        }

        private void Temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}