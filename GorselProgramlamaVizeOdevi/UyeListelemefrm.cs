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
        public UyeListelemefrm()
        {
            InitializeComponent();
            
        }
        SqlConnection baglanti= new SqlConnection()

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("connection_string_here");

            // Bağlantı açılıyor
            baglanti.Open();

            // SQL komutu oluşturuluyor ve parametreler belirtiliyor
            SqlCommand komut = new SqlCommand("INSERT INTO uyelisteleme(tc, ad, soyad, yas, cinsiyet, telefon, adres, email) VALUES(@tc, @ad, @soyad, @yas, @cinsiyet, @telefon, @adres, @email)", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTC.Text);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@yas", txtYas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", txtCinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);

            // Komutu veritabanında çalıştırılıyor
            komut.ExecuteNonQuery();

            // Bağlantı kapatılıyor
            baglanti.Close();

            // Kullanıcıya bilgi veriliyor
            MessageBox.Show("Üye kaydı yapıldı");

            // TextBox kontrolleri temizleniyor
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

    }

       

        private void btnyukle_Click(object sender, EventArgs e)
        {
        private void btnYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON Dosyası|*.json"; // Yalnızca JSON dosyalarını göster
            if (dialog.ShowDialog() == DialogResult.OK) // Kullanıcı dosya seçerse
            {
                string json = File.ReadAllText(dialog.FileName); // Seçilen dosyanın içeriğini oku
                List<Uye> uyeListesi = JsonConvert.DeserializeObject<List<Uye>>(json); // JSON'u uygun şekilde deserialize et
                foreach (Uye uye in uyeListesi) // Her üye için
                {
                    // Üye listesini ekrana ekleme veya başka bir işlem yapma
                    // Örneğin, bir DataGridView kontrolüne ekleyebilirsiniz:
                    dataGridView1.Rows.Add(uye.Ad, uye.Soyad, uye.Email);
                }
                MessageBox.Show("Üye listesi yüklendi.");
            }
        }

    }
