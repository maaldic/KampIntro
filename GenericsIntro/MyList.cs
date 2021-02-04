using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>//Generic classtır. Ben bunu liste olarak kullanmak istiyorum. T, type'tan gelir. Aslında istediğimiz harfi yazabiliriz oraya. Ben MyList'imde T ile çalışacağım demektir.
        //Verilen tipe göre (T) aşağısı yapılandırılır. Başka bir deyişle ben MyList'imde T ile çalışacağım demektir.
    {
        T[] items; //List arka planda bir dizi yönettiğinden dizi tanımlıyoruz. T tipinde bir dizi tanımladık. Hem class içinden hem de metot içinden ulaşılabilir bir dizidir. 
        //ctor=constructor metodu. class'ı bir yerde new'lersek "public MyList" otomatik çalışacak.
        public MyList() //Array referans tip olduğundan add'lemek veya üzerinde işlem uygulayabilmek için önce onu new'lememiz gerekiyor. class ile aynı isim olur constructor.
        {
            items = new T[0];   //new'lediğin anda 0 elemanlı array oluşturdun. item'ları ekleyebileceği bir hafıza oluşturduk aslında.
        }
        public void Add(T item)//(En başta T yerine string vardı) Add, string ile çalışmak zorundadır. Onun yerine benim çalışacağım tipi o an programcı new'lerken hangi tip derse o olsun.
            // İşte T'de vereceğimiz tipe karşılık geliyor.
            // O yüzden string yerine T diyorum ki istediğim elemanın türü de odur demek.
            //main dosyasında MyList'i string olarak tanımladığım için T string veri tipinde olmuş oldu.
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            //dizinin eleman sayısını 1 artırıyoruz. Fakat her new yaptığımızda ref numaramız değiştiğinden dizide hep tek eleman oluşuyor böylece.
            //önüne geçmek için ref no'yu birine tutturmamız lazım.  T[] tempArray = items;

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }                                               //tempArray'e emaneten atadığım değerleri items'a geri almam gerek.

            items[items.Length - 1] = item; //aslında eklenmek istenen elemanı şu an ekleyebildik.
        }
        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
