using System;
using System.Collections.Generic;
using System.Text;

namespace Odev
{
    class SepetManager
    {
        public void Ekle(Urun urun, Urun ads)
        {
            Console.WriteLine("Sepete Eklendi: " + urun.UrunAdi + " " + ads.UrunRengi);
        }
    }
}
