using System;

namespace Tutorials;

class Program
{
    private static void Main(string[] args)
    {
        //Array.sort, Array.clear, Array.reverse, Array.indexOf, Array.resize
        int[] sayiDizisi = {6,9,4,8,3,1,7};
        Console.WriteLine("Orjinal sayiDizisi");
        foreach (var sayi in sayiDizisi)
        {
            Console.Write(sayi + ", ");
        }

        Array.Sort(sayiDizisi);             //harf sırasına göre de sıralama yapabiliyor ??
        Console.WriteLine("\nSıralanmış(sort) sayiDizisi");
        foreach (var sayi in sayiDizisi)
        {
            Console.Write(sayi + " ");
        }
        
        Array.Clear(sayiDizisi,2,2);        // sadece array verip index ve uzunluk vermezsek dizinin tamamına 0 atıyor
        Console.WriteLine("\n2. ve 3. index 0 değerli sayiDizisi");
        foreach (var sayi in sayiDizisi)
        {
            Console.Write(sayi + " ");
        }
        
        Array.Reverse(sayiDizisi);
        Console.WriteLine("\nTers çevirilmiş sayiDizisi");
        foreach (var sayi in sayiDizisi)
        {
            Console.Write(sayi + " ");
        }
        
        Console.WriteLine("\nDeğeri 8 olan elemanın indexi sayiDizisi:");
        Console.Write(Array.IndexOf(sayiDizisi,8));

        Array.Resize<int>(ref sayiDizisi,9);
        Console.WriteLine("\n9. eleman eklenmiş sayiDizisi");
        sayiDizisi[8] = 5;
        foreach (var sayi in sayiDizisi)
        {
            Console.Write(sayi + " ");
        }

    }
}
