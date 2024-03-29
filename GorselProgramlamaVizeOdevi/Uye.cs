using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlamaVizeOdevi
{
    public class Uye
    {
        public static List<Uye> UyeList=new List<Uye>();
        public string TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public string Cinsiyet { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }

        public Uye(string tcKimlikNo, string ad, string soyad, int yas, string cinsiyet, string telefon, string adres, string email)
        {
            TC = tcKimlikNo;
            Ad = ad;
            Soyad = soyad;
            Yas = yas;
            Cinsiyet = cinsiyet;
            Telefon = telefon;
            Adres = adres;
            Email = email;
        }
        public override string ToString()
        {
            return $"TC: {TC}, Ad: {Ad}, Soyad: {Soyad}, Yaş: {Yas}, Cinsiyet: {Cinsiyet}, Telefon: {Telefon}, Adres: {Adres}, Email: {Email}";
        }
        public void tabloekle(DataTable tablo)
        {
            tablo.Rows.Add(new Object[] { TC});
        }
    }


}
