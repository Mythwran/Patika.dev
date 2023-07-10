using System;

namespace Tutorials;

class Program
{
    private static void Main(string[] args)
    {
        int month = DateTime.Now.Month;

        switch (month)                      //month değeri caselerdeki veriler ile karşılaştırılacak
        {
            case 1:                         //month == 1 ise 
                Console.WriteLine("Ocak");
                break;                      //break; ya da return; komutu ile bitirilmek zorunda!!!
            case 3:                         //month == 3 ise
                Console.WriteLine("Mart");
                break;
            case 7:                         //month == 7 ise
                Console.WriteLine("Temmuz");
                break;
            default:                        //verilen caselerden herhangi biri olmazsa uygulanır. Zorunlu değildir.
                Console.WriteLine("Aylardan Kasım!!!");
                break;
        }
        switch (month)
        {
            case 12:                //
            case 1:                 //Çoklu caselerde tek bir kod bloğu çalıştırılabilir.
            case 2:                 //
                Console.WriteLine("Kış mevsimi");
                break;            
        }
    }
}
