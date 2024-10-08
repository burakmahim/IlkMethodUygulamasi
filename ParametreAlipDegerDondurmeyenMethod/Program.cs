using System;

namespace ParametreAlipDegerDonduremeyenMethod
{
    class program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan isim ve soyisim bilgilerini alalım
            Console.Write("İsminizi girin: ");
            string isim = Console.ReadLine();

            Console.Write("Soyisminizi girin: ");
            string soyisim = Console.ReadLine();

            // İsim ve soyisim bilgilerini alan metodu çağırıyoruz
            HosGeldiniz(isim, soyisim);
        }

        // Parametre olarak isim ve soyisim alan, geriye değer döndürmeyen metot
        static void HosGeldiniz(string isim, string soyisim)
        {
            Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");
        }
    }
}