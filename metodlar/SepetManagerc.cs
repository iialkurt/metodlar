using System;
using System.Collections.Generic;
using System.Text;

namespace metodlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi.. :"+urun.UrununAdi);
            Console.WriteLine("Sepete Eklendi.. :" + urun.Aciklama);
            Console.WriteLine("Sepete Eklendi.. :" + urun.Fiyati);
            Console.WriteLine("Sepete Eklendi.. :" + urun.StokAdeti);
            Console.WriteLine("--------------------------");
        }

        public void Ekle2(string UrunAdi, string Aciklama, double fiyat)
        {
            Console.WriteLine("Sepete Eklendi.. :" + UrunAdi);
            Console.WriteLine("Sepete Eklendi.. :" + Aciklama);
            Console.WriteLine("Sepete Eklendi.. :" + fiyat);
        }
    }
}
