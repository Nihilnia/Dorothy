using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    static class HelperMethods { 
        
        public static string KarakterDuzelt(string girilenKarakter)
        {
            return girilenKarakter.
                Replace("ö", "o").
                Replace("ü", "u").
                Replace("ğ", "g").
                Replace("ş", "s").
                Replace("ç", "c");
        }
    
    }


    class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public double UrunFiyat { get; set; }
        public bool isGecerli { get; set; }
    }

    static class Veritabani {
        static Urun[] urunler;

        static Veritabani()
        {
            urunler = new Urun[5];
            urunler[0] = new Urun() { UrunID = 1, UrunFiyat = 1.11, UrunAdi = "Urun01", isGecerli = true };
            urunler[1] = new Urun() { UrunID = 2, UrunFiyat = 2.21, UrunAdi = "Urun02", isGecerli = false };
            urunler[2] = new Urun() { UrunID = 3, UrunFiyat = 3.31, UrunAdi = "Urun03", isGecerli = true };
            urunler[3] = new Urun() { UrunID = 4, UrunFiyat = 4.41, UrunAdi = "Urun04", isGecerli = false };
            urunler[4] = new Urun() { UrunID = 5, UrunFiyat = 5.51, UrunAdi = "Urun05", isGecerli = true };
        }

        public static Urun[] UrunleriGetir()
        {
            return urunler;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string karakterz = "bişeyler ölümçül";

            karakterz = HelperMethods.KarakterDuzelt(karakterz);

            Console.WriteLine(karakterz);

            Urun[] TumUrunler = Veritabani.UrunleriGetir();

            foreach (var item in TumUrunler)
            {
                Console.WriteLine("Urun Adi: {0}, Urun Gecerli mi: {1}", item.UrunAdi, item.isGecerli);
            }

            Console.Read();
        }
    }
}
