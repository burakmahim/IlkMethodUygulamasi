using System;

namespace TamsayiDondurenMethod
{
    class program
    {
        static void Main(string[] args)
        {
            // Rastgele sayının 2'ye bölümünden kalanı döndüren metodu çağırıyoruz.
            int kalan = kalanSayi();
            Console.WriteLine($"kalan sayi: {kalan}");

        }

        // Geriye tamsayı döndüren bir metot
        static int kalanSayi()
        {
            // Rastgele bir sayı üretelim
            Random rand = new Random();
            int sayi = rand.Next(1, 50);

            // Rastgele üretilen sayıyı ekrana yazdıralım
            Console.WriteLine($"Rastgele üretilen sayı: {sayi}");

            // 2'ye bölümünden kalan
            int kalan = sayi % 2;

            // Geriye kalan değeri döndürelim
            return kalan;
        }
    }
}