# 4 Farklý Metot Ýçeren Uygulama

Bu proje, farklý metodlarý kullanarak kullanýcýdan veri alýr, rastgele sayý üretir ve iþlem yapar. Aþaðýda her bir metodun iþlevi ve proje hakkýnda genel bilgi bulabilirsiniz.

## Metotlar

### 1. Geriye Deðer Döndürmeyen Bir `void` Metot

Bu metot, ekrana sevdiðiniz bir þarký sözünü yazdýrýr.

```
static void SarkiSozu()
{
    Console.WriteLine("Dünya dönüyor, bir þey demiyor...");
}
```
### 2. Geriye Tamsayý Döndüren Bir metot

Rastgele bir sayý üretip bu sayýnýn 2'ye bölümünden kalaný geriye döndürsün.

```
static int RastgeleSayiVeKalan()
{
    Random random = new Random();
    int sayi = random.Next(1, 100); // 1 ile 100 arasýnda rastgele sayý üret
    Console.WriteLine("Rastgele Üretilen Sayý: " + sayi);
    return sayi % 2;
}
```

### 3. Parametre Alan ve Geriye Deðer Döndüren Bir Metot
Bu metot, parametre olarak aldýðý iki sayýnýn çarpýmýný hesaplar ve sonucu geriye döndürür.

```
static int Carpim(int sayi1, int sayi2)
{
    return sayi1 * sayi2;
}

```

### 4. Parametre Alan ve Geriye Deðer Döndürmeyen bir Metot
Parametre olarak isim ve soyisim bilgilerini alýp " Hoþ Geldiniz {isim} {soyisim} " þeklinde ekrana bassýn.

```
static void HosGeldiniz(string isim, string soyisim)
{
    Console.WriteLine($"Hoþ Geldiniz {isim} {soyisim}");
}

```