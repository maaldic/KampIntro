using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //2 Numara mobilya kategoridir.
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "kalem", UnitPrice = 35, UnitsInStock = 5 };

            ProductManager productManager = new ProductManager(); //ProductManager class'ını tanıttık.              Buradaki adrese 101 diyelim.
            productManager.Add(product1); //Product türünde bir değişken istiyor. Yani product 1 veya 2.            Buraya product1'i yolladığında aslında 101 no'lu adrese yolluyorsun.
            Console.WriteLine(product1.ProductName); //cevap, masa değil kamera.

            productManager.Topla2(3, 6);



            //int sayi = 100;
            //productManager.BiseyYap(sayi);
            //Console.WriteLine(sayi); //cevap, 99 değil 100.


            
           

        }
    }
}
