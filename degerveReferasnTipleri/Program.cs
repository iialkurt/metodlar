using System;

namespace degerveReferasnTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            string isim1 = "ismail";
            string isim2 = "Esra";
            isim1 = isim2;
            isim2 = "Nisa";
            Console.WriteLine(isim1);
        }
    }
}
