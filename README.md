# 4 Farkl� Metot ��eren Uygulama

Bu proje, farkl� metodlar� kullanarak kullan�c�dan veri al�r, rastgele say� �retir ve i�lem yapar. A�a��da her bir metodun i�levi ve proje hakk�nda genel bilgi bulabilirsiniz.

## Metotlar

### 1. Geriye De�er D�nd�rmeyen Bir `void` Metot

Bu metot, ekrana sevdi�iniz bir �ark� s�z�n� yazd�r�r.

```
static void SarkiSozu()
{
    Console.WriteLine("D�nya d�n�yor, bir �ey demiyor...");
}
```
### 2. Geriye Tamsay� D�nd�ren Bir metot

Rastgele bir say� �retip bu say�n�n 2'ye b�l�m�nden kalan� geriye d�nd�rs�n.

```
static int RastgeleSayiVeKalan()
{
    Random random = new Random();
    int sayi = random.Next(1, 100); // 1 ile 100 aras�nda rastgele say� �ret
    Console.WriteLine("Rastgele �retilen Say�: " + sayi);
    return sayi % 2;
}
```

### 3. Parametre Alan ve Geriye De�er D�nd�ren Bir Metot
Bu metot, parametre olarak ald��� iki say�n�n �arp�m�n� hesaplar ve sonucu geriye d�nd�r�r.

```
static int Carpim(int sayi1, int sayi2)
{
    return sayi1 * sayi2;
}

```

### 4. Parametre Alan ve Geriye De�er D�nd�rmeyen bir Metot
Parametre olarak isim ve soyisim bilgilerini al�p " Ho� Geldiniz {isim} {soyisim} " �eklinde ekrana bass�n.

```
static void HosGeldiniz(string isim, string soyisim)
{
    Console.WriteLine($"Ho� Geldiniz {isim} {soyisim}");
}

```