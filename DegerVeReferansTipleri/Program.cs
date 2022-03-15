using System;

namespace DegerVeReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sayısal veri tipleri (yani int, double, float, decimal, bool veri tipleri) değer tip dir.  
            // Bellekte stack ve heap olarak 2 alan var. Değer tip olanlar stack alanında işlem görür. 
            // sayi1 = sayi2 yapıldığında sayi2 nin değeri sayi1'e eşitlenir. Sadece değeri alır ve sonra aradaki bağ kopar.
            // sonraki satırlarda sayi2 nin değerinin değişmesi sayi1 in değerini değiştirmez, çünkü bağ kopmuştur.
            int sayi1 = 30;
            int sayi2 = 40;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
            Console.WriteLine("---------------");

           // Array, class, interface veri tipleri referans tip dir.
           // sayilar1 array i için stack de bir değişken tanımlanır. Değerleri heap de açılan alana yazılır.
           // stack ve heap de değerler belirli bir adreste tutulur.
           // sayılar2 array i için de stack de bir değişken tanımlanır ve değerleri heap de tutulur. Adres bellidir.
           // sayilar1 = sayilar2 yapıldığında sayılar1 in referans numarası sayilar2 nin referans numarasına eşitlenir.
           // sayilar2 deki değerler değiştiğinde sayilar1 de değişmiş olur.
            
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);



        }
    }
}
