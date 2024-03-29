using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlamaVizeOdevi
{
  
        public class Kitap
        {
        public static List<Kitap> KitapList = new List<Kitap>();
        public string BarkodNo { get; set; }
            public string KitapAdi { get; set; }
            public string Yazari { get; set; }
            public string YayinEvi { get; set; }
            public int SayfaNo { get; set; }
            public string Turu { get; set; }
            public string RafNo { get; set; }
        }
    public DataTable dtKitap;
    public KitapSil()
    {
        InitializeComponent();
        Kitap = new DataTable();
        dtKitap.Columns.Add("BarkodNo");
        dtKitap.Columns.Add("KitapAdi");
        dtKitap.Columns.Add("Yazari");
        dtKitap.Columns.Add("YayinEvi");
        dtKitap.Columns.Add("SayfaNo");
        dtKitap.Columns.Add("Turu");
        dtKitap.Columns.Add("RafNo");

        dgvKitaplar.DataSource = dtKitap;
    }


}
