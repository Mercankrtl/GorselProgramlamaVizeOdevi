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


namespace GorselProgramlamaVizeOdevi
{
    public partial class UyeListelemefrm : Form
    {
        DataTable dtuyeler;
        public UyeListelemefrm()
        {
            InitializeComponent();
            dtuyeler = new DataTable();
            dtuyeler.Columns.Add("TC");

            dgvuyeler.DataSource = dtuyeler;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }

        private void btndosyaekle_Click(object sender, EventArgs e)
        {
            string yazilacak = JsonSerializer.Serialize<List<Uye>>(Uye.UyeList);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSon Dosyasý|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                string dosyaYolu = dialog.FileName;
                File.WriteAllText(dosyaYolu, yazilacak, Encoding.UTF8);

            }
        }

        private void btnyukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSon Dosyasý|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(dialog.FileName);
                Uye.UyeList = JsonSerializer.Deserialize<List<Uye>>(data);
                foreach (Uye uye in Uye.UyeList)
                {
                    uye.tabloekle(dtuyeler);
                }
            }
        }
    }
}
