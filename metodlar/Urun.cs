using System;
using System.Collections.Generic;
using System.Text;

namespace metodlar
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrununAdi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdeti { get; set; }
    }
}
