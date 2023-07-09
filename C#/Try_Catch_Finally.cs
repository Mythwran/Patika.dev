using System;

namespace Tutorials;

class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Bir Değer Giriniz:");
            int a = int.Parse(Console.ReadLine());
        }
        catch (ArgumentNullException ex)    //Boş değer alınca
        {
            Console.WriteLine("Boş değer girdiniz.");
            Console.WriteLine("Hata: " + ex);
        }
        catch (OverflowException ex)    //Int değer dışında bir değer alındığında
        {
            Console.WriteLine("Çok büyük ya da çok küçük değer girdiniz");
            Console.WriteLine("Hata: " + ex);
        }
        catch (FormatException ex)      //Int e çevirilemeyen bir değer alındığında
        {
            Console.WriteLine("Sayıya çevrilemeyen bir değer girdiniz");
            Console.WriteLine("Hata: " + ex);
        }
        catch (Exception ex)    //Herhangi bir hata alındığında
        {
            Console.WriteLine("Bir hata aldınız!");
            Console.WriteLine("Hata: " + ex);
        }
        finally     //Her şartta çalışan son kod bloğu
        {
            Console.WriteLine("İşlem tamamlandı.");
        }
    }
}
