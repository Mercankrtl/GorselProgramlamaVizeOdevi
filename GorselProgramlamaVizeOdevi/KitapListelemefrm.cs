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
        public KitapListelemefrm()
        {
            InitializeComponent();
        }
        public partial class KitapListelemefrm : Form
        {
            DataTable dtkitaplar;
            public KitapListelemefrm()
            {
                InitializeComponent();
                dtkitaplar = new DataTable();
                dtkitaplar.Columns.Add("K.BarkodNo", "KitapAdi", "Yazari", "YayinEvi", "SayfaNo", "Turu", "RafNo",);

                dgvkitaplar.DataSource = dtkitaplar;
            }


            private void btnEkle_Click(object sender, EventArgs e)
            {


                KitapListeleme nesne = new KitapListeleme();
                nesne.Show();

            }


            private void btnIptal_Click(object sender, EventArgs e)
            {

            }

            private void btnSil_Click(object sender, EventArgs e)
            {

            }
        }

    }
