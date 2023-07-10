using System;

namespace Tutorials;

class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz");
        int sayac = int.Parse(Console.ReadLine());
        for (int i = 0; i < sayac; i++)
        {
            if (i == 9)
            {
                Console.WriteLine("Sayac 9 a geldi ve kod sonlandı!");
                break;          //içinde bulunduğu döngüyü tamamen sonlandırır.
            }

            if (i == 5)
            {
                Console.WriteLine("Sayac 5 e geldi ve sayılmadı");
                continue;       //Sadece olduğu döngüyü sonlandırır ve for döngüsü kaldığı yerden devam eder
            }
            Console.WriteLine(i);
        }
    }
}
