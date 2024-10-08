using System;

namespace DegerDonduremeyenVoidMethod
{
    class program
    {
        static void Main(string[] args)
        {
            // Metodun çağrılması
            sarkiSozu();
        }

        // Geriye değer döndürmeyen void metot
        static void sarkiSozu()
        {
            // Ekrana şarkı sözünü yazdır
            Console.WriteLine("Bin derdim var hangisine yanayım...");
        }
    }
}