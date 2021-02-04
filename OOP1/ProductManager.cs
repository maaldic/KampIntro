using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) //Buradaki product 101 no'lu bellek adresidir.
        {
            //product.ProductName = "kamera";  101'in productname'i kamera olmuş oldu.
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public int Topla(int sayi1, int sayi2)  //public int ile public void farkını açıkladı bu ve altındaki kod dizisiyle.
            //Public yanındaki int  ise return edilen değer de int olmalıdır.
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);
        }

        //public void BiseyYap(int sayi)
        //{
        //    sayi = 99;  
        //}
    }
}
