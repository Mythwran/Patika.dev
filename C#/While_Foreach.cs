using System;

namespace Tutorials;

class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());
        int sayaç = 0, toplam = 0;

        while (sayaç <= sayi)       //() içi true olduğu sürece kod bloğu tekrarlanır.
        {
            toplam += sayaç;
            sayaç++;                //While() döngüleri sonsuz döngüye dönüşme ihtimaller fazladır. DIKKAT!!!
        }
        Console.WriteLine(toplam / sayi);

        char c = 'a';               //Char veri tipi arttırılıp azaltılabilir
        while (c <= 'z')
        {
            Console.Write(c);
            c++;                    //'a' dan 'b' ye değişim. İngiliz alfabesi üzerinden ilerliyor
        }

        string[] arabalar = { "Opel", "BMW", "Ford", "Toyota", "Honda", "Nissan" };     // string verileri içeren bir dizi oluşturuluyor
        foreach (var araba in arabalar)             //Dizi içindeki elemanları tek tek kontrol edip işlem yapabilmek için
        {
            Console.WriteLine(araba);
        }
    }
}
