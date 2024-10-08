using System;

namespace ParametreAlipDegerDondurenMethod
{
    class program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan iki sayı alalım
            Console.Write("Birinci sayiyi giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayiyi giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            // İki sayının çarpımını bulan metodu çağırıyoruz
            int carpimSonucu = carpim(sayi1, sayi2);

            // Sonucu ekrana yazdırıyoruz
            Console.Write($"cevap: {carpimSonucu}");
        }

        static int carpim(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}