using System;

namespace Tutorials;

class Program
{
    private static void Main(string[] args)
    {
        string[] dizi = new string[5];  //5 elemanlı içeriği string olan dizi tanımlaması
        dizi[0] = "1. eleman";          //dizinin ilk elemanının atanması, dizi indexleri 0 dan başlar.
        dizi[3] = "EV";

        int[] rakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };     //Farklı bir dizi tanımlama çeşidi

        Console.WriteLine(dizi[0]);
        Console.WriteLine(rakamlar[4]);

        foreach (int rakam in rakamlar)
        {
            Console.WriteLine(rakam);
        }

        Console.Write("Lütfen dizi boyutunu giriniz: ");
        int n = int.Parse(Console.ReadLine());

        int[] sayiDizisi = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Lütfen {i + 1}. dizi elemanın değerini giriniz: ");
            sayiDizisi[i] = int.Parse(Console.ReadLine());
        }
        foreach (int sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
    }
}
