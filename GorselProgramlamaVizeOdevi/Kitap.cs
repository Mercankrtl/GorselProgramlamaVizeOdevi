using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GorselProgramlamaVizeOdevi
{

    public class Kitap
    {
        private List<Kitap> kitapListesi;

        public Kitap()
        {
            kitapListesi = new List<Kitap>();
        }

        public void KitapEkle(Kitap kitap)
        {
            kitapListesi.Add(kitap);
        }

        public void KitapSil(int index)
        {
            if (index >= 0 && index < kitapListesi.Count)
            {
                kitapListesi.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Geçersiz indeks");
            }
        }

        public void KitapListesiniYukle(string jsonFilePath)
        {
            try
            {
                string json = File.ReadAllText(jsonFilePath);
                kitapListesi = JsonConvert.DeserializeObject<List<Kitap>>(json);
                Console.WriteLine("Kitap listesi başarıyla yüklendi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }

        public void KitapListesiniYazdir()
        {
            foreach (Kitap kitap in kitapListesi)
            {
                Console.WriteLine(JsonConvert.SerializeObject(kitap));
            }
        }

        public void KitapListesiniDosyayaYaz(string jsonFilePath)
        {
            string json = JsonConvert.SerializeObject(kitapListesi, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
            Console.WriteLine("Kitap listesi başarıyla dosyaya yazıldı.");
        }
    }