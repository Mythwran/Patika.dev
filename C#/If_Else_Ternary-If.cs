using System;

namespace Tutorials;

class Program
{
    private static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;
        if (time <= 11 && time >= 6)
        {
            Console.WriteLine(time);            //2 ve daha fazla satırdan oluşan if bloklarında {} kullanmak şart
            Console.WriteLine("Günaydın");
        }
        else if (time <= 18)
            Console.WriteLine("İyi günler!");   //tek satırlık if bloklarında {} yapısı şart değil
        else
            Console.WriteLine("İyi geceler!");

        //if ternary gösterimi
        string selam = time <= 18 ? "İyi günler" : "İyi geceler!";  //tek koşullu ternary gösterim
        selam = time <= 11 && time >= 6 ? "Günaydın" : time <= 18 ? "İyi günler!" : "İyi geceler!"; // 2 koşullu ternary gösterim
        Console.WriteLine(selam);
    }
}
