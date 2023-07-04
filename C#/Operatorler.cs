using System;

namespace Tutorials;

class Program
{
    private static void Main(string[] args)
    {
        //Atama ve İşlemli Atama Operatörleri (=, +=, -=, *=, /=)
        int a = 1, b = 6, c = 0;
        Console.WriteLine("a: " + a + " b: " + b + " c: " + c);
        a = b;
        c += 5;
        b *= 6;
        Console.WriteLine("a: " + a + " b: " + b + " c: " + c);
        //Mantıksal Operatörler (||, &&, !)
        bool dogrumu = false;
        dogrumu = a < b && c < a;
        Console.WriteLine("a, b'den küçük mü ve c, a'dan küçük mü? " + dogrumu);
        dogrumu = a == b || c < b;
        Console.WriteLine("a, b'ye eşitmi ya da c, b'den küçük mü? " + dogrumu);
        Console.WriteLine("Son dogrumu'nun degerinin tersi: " + !dogrumu);    // son boolean değerini tersine çevirir
        //İlişkisel Operatörler (==,!=, <, >, >=,<=)
        bool esitmi = false;
        esitmi = a == b;
        Console.WriteLine("a, b'ye eşit mi? " + esitmi);
        esitmi = a < b;
        Console.WriteLine("a, b'den küçük mü? " + esitmi);
        //Aritmetik (+, -, *, /, %, ++, --)
        c = a + b;
        Console.WriteLine("a ile b toplanıp c'ye eşit olur: " + c);
        b = a;
        Console.WriteLine("a ile b birbirine eşitlendi ve değerleri a: " + a + " b: " + b);
        c = a++;
        Console.WriteLine("++ işlemi değişkenden sonra olur ise c = a++: " + c);
        c = ++b;
        Console.WriteLine("++ işlemi değişkenden önce olur ise c = ++b: " + c);
        c = b % a;
        Console.WriteLine("b'nin a'ya bölümünden kalan: " + c);
    }
}
