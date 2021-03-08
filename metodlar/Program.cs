using System;

namespace metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrununAdi = "Elma";
            urun1.Fiyati = 80;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdeti = 5;

            Urun urun2 = new Urun();
            urun2.UrununAdi = "Karpuz";
            urun2.Fiyati = 60;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //foreach (Urun urun in urunler)
            //{
            //    Console.WriteLine(urun.UrununAdi);
            //    Console.WriteLine(urun.Fiyati);
            //    Console.WriteLine(urun.Aciklama);
            //}
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Elma","Yeşil Elma",12);
            
        }
    }
}
