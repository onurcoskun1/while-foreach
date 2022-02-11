using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1 den başlayarak konsoldan girilen sayı dahil ortalama hesaplayıp konsola yazdıralım.
           //Console.Write("Lütfen bir sayı giriniz:");
           //int sayi = int.Parse(Console.ReadLine());
           //int sayac=1;
           //int toplam=0;
           //while (sayac<=sayi) 
           //{
           //    toplam+=sayac;
           //    sayac ++;
           //}
           //Console.WriteLine(toplam/sayi);
           //
           //// a'dan z'ye kadar bütün harfleri console'a yazdır.
           //
           //char karakter = 'a';
           //
           //while (karakter<'z')
           //{
           //    Console.Write(karakter);
           //    karakter++;
           //}
            
            string[] arabalar = {"Bmw", "Ford", "Toyota", "Lambo"};
            
            foreach (var araba in arabalar)
	        {
                Console.WriteLine(araba);
	        }
        }
    }
}
