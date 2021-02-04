using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Gömlek";
            urun1.UrunFiyati = 80;
            urun1.UrunKodu = 585;
            urun1.UrunRengi = "Mavi";
            urun1.UretilmeTarih = "20/10/2012";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Tişört";
            urun2.UrunFiyati = 50;
            urun2.UrunKodu = 586;
            urun2.UrunRengi = "Turuncu";
            urun2.UretilmeTarih = "20/11/2012";

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Kravat";
            urun3.UrunFiyati = 30;
            urun3.UrunKodu = 587;
            urun3.UrunRengi = "Siyah";
            urun3.UretilmeTarih = "20/12/2012";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1, urun2);  //gömlek turuncu çıktısını verir.
        }   
    }
    
}
