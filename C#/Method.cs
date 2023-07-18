using System;

namespace Tutorials;

class Program
{
    private static void Main(string[] args)
    {
        int a = 5, b = 7;

        int sonuc = topla(a, b);

        sinif ornek = new sinif();                  //başka bir sınıf içinden method çağırmak için o sınıftan bir yeni sınıf olurturmamız gerek.
        ornek.yazdir((Convert.ToString(sonuc)));    //Başka bir sınıftan method çağırma

        int sonuc2 = ornek.refKareAl_Topla(ref a,ref b);    //ref keywordu ile meyhod çağırma

        ornek.yazdir(Convert.ToString(sonuc2));
        
    }
    static int topla(int x, int y)     //Toplama methodu, geriye int değer döndürüyor. Erişim belirteci yazmazsak private olur.
        {                              //Static method içinde sadece static methodlar erişilebilir
            return x + y;
        }
}
class sinif
{
    public void yazdir(string str)      //public olarak tanımlarsak class dışında da erişilebilir
    {                                   //void ile tanımlarsak geriye değer dönmez
        Console.WriteLine(str);
    }

    public int refKareAl_Topla(ref int x, ref int y)    //ref keywordu ile method tanımlarsak, methoda verilen değerler işleniyorsa değerleri değişir.
    {                                                   //herhangi bir değer türü ile tanımlarsak geriye değer dönmek zorunda
        x*=x;                                           //int, long, float, double, decimal, char, bool, byte, short, struct, enum
        y*=y;
        return x+y;                                     //değer dönüşü
    }
}
