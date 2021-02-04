using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategoriler";
            Console.WriteLine(kategoriEtiketi);
         
            bool sistemeGirisYapmisMi = false;

            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else
            {
                Console.WriteLine("Eşitlik butonu");
            }

            if (sistemeGirisYapmisMi==false)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
        }
    }
}
