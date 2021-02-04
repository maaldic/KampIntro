﻿using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)     
        {
            MyList<string> isimler = new MyList<string>(); //class'ı tanıttık. MyList generic bir class olduğundan ve bu class'ın içinde yer alan metotlar verilecek tipe bağımlı
            isimler.Add("Engin"); //çalışacaklarından çalışacağı veri tipinin söylenmesi gerekir. <> arasında verisini de tanımladık böylece. 

            Console.WriteLine(isimler.Length);

            isimler.Add("Kerem");

            Console.WriteLine(isimler.Length);

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
