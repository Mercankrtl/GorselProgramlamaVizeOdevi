using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlamaVizeOdevi
{
    public class EmanetKitap
    {
        public string BarkodNo { get; set; }
        public string KitapAdi { get; set; }
        public string Yazari { get; set; }
        public string YayinEvi { get; set; }
        public int SayfaNo { get; set; }
        public int KitapSayisi { get; set; }

        // JSON formatına dönüştürme metodu
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class EmanetKitapManager
    {
        private EmanetKitap emanetKitap;

        public void EmanetKitapEkle(EmanetKitap kitap)
        {
            emanetKitap = kitap;
        }

        public void EmanetKitapIptal()
        {
            emanetKitap = null;
        }

        public void EmanetKitapTeslimEt()
        {
            if (emanetKitap != null)
            {
                // Teslim edilen emanet kitabı konsola yazdır
                Console.WriteLine("Emanet Kitap Teslim Edildi:");
                Console.WriteLine(emanetKitap.ToJson());

                // Teslim edilen emanet kitabını bir dosyaya yazdır
                string json = emanetKitap.ToJson();
                File.WriteAllText("emanet_kitap.json", json);
            }
            else
            {
                Console.WriteLine("Emanet kitap bulunmamaktadır.");
            }
        }
    }
}
