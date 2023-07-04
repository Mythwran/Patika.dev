using System;

namespace Tutorials;

class Program
{
    private static void Main(string[] args)
    {
        //Değişken tanımlamaları
        string isim = "Burak"; // sınırsız yer kaplayabilir
        string sayi = "22";
        byte b = 1; // 1 byte yer kaplar
        int i = 0;  // 4 byte yer kaplar, tam sayıdır
        float f = 3.14f; // 4 byte yer kaplar ondalıklı sayıdır.

        //String işlemleri
        string soyad = "Dinçer";
        string tamIsim = isim + " " + soyad;
        Console.WriteLine("Ad Soyad: " + tamIsim);

        //Integer İşlemleri ve çeviriler
        int total = i + Convert.ToInt32(f) + int.Parse(sayi) + b; //byte değeri toplamda kullanılabildi!
        Console.WriteLine("Toplam sayı: " + total);

        //DateTime
        DateTime dt = DateTime.Now;
        Console.WriteLine("Tarih: " + dt.ToString("dd/MM/yyyy"));
        Console.WriteLine("Saat: " + dt.ToString("HH:mm:ss"));
    }
}
