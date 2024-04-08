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
    public partial class EmanetKitapForm : Form
    {
        private EmanetKitapManager kitapManager;

        public EmanetKitapForm()
        {
            InitializeComponent();
            kitapManager = new EmanetKitapManager();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EmanetKitap kitap = new EmanetKitap
            {
                BarkodNo = txtBarkodNo.Text,
                KitapAdi = txtKitapAdi.Text,
                Yazari = txtYazari.Text,
                YayinEvi = txtYayinEvi.Text,
                SayfaNo = Convert.ToInt32(txtSayfaNo.Text),
                KitapSayisi = Convert.ToInt32(txtKitapSayisi.Text)
            };

            kitapManager.EmanetKitapEkle(kitap);
            MessageBox.Show("Emanet kitap başarıyla eklendi.");
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            kitapManager.EmanetKitapTeslimEt();
            MessageBox.Show("Emanet kitap başarıyla teslim edildi.");
        }
    }
}
