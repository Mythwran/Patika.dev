using System;

namespace Tutorials;

class Program
{
    private static void Main(string[] args)
    {
        //Tip Dönüşümleri
        //byte>short>int>long>float>double> değişkenleri herhangi bir çevirme yapmadan birbirlerine doğru çevrilerek işleme alınabilir
        //char>string>object
        
        // Implicit Conversion (bilinçsiz değişim)
        byte b = 1; 
        short s = b; 
        int i = 3 + s;
        long l = 7 + i;
        float f = 4 + i;
        double d = 5 + f;           // şeklinde birbirlerine eklenebilir
        decimal dc = 6 + (decimal)d;// double türü decimal türüne imlicit olarak değişmiyor   
        char c = 'j'; string ss1 = "yazi"; object o = ss1 + c;   // o değeri "yazij" olur
            
        // Explicit Conversion (bilinçli değişim)   daha büyük veri tipini küçük veri tipine dönüştürme, bu dönüştürmeler hata verebilir (exeptions)
        byte b1 = 10; short s1 = 50; int i1 = 750; float f1 = 10.25f, f2 = 10.99f;
        byte b2 = (byte)i; short s2 = (short)i;     // şeklinde string ifadeleri ya da baska ifadeleri çevirilebiliyorsa
        int i2 = (int)f1; int i3 = (int)f2;        // ondalıklı çevirmede değer kaybolabilir, değerin sadece tam sayı kısmını alır ve üste tamamlamaz
            
        // .ToString() methodu, değerleri string formatına çevirilebiliyorsa
        byte b3 = 10; int i4 = 566;
        string str = b3.ToString() + i4.ToString();         // str: "10556" olur, array ve listelerde dikkatli ol!
            
        //System.Convert sınıfı
        string str1 = "15", str2 = "55";
        int i5 = Convert.ToInt32(str1) + Convert.ToInt32(str2);  // using System program başında belirtilmeli, i5: 70 olur
            
        //Int.Parse() methodu
        string str3 = "22", str4 = "77";
        int i6 = Int32.Parse(str3) + Int32.Parse(str4);              // Parse() parantez içine sadece string değer alır (char?), i6: 99 olur
        double d1 = Double.Parse(str3) + Double.Parse(str4);         // d1: 99 olur
    }
}
