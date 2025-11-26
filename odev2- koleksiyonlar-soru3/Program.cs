using System;
using System.Collections;

class Program
{
    static void Main()
    {
        string sesliler = "aeıioöuüAEIİOÖUÜ";
        ArrayList bulunanHarfler = new ArrayList();

        Console.Write("Bir cümle giriniz: ");
        string cumle = Console.ReadLine();

        foreach (char ch in cumle)
        {
            if (sesliler.Contains(ch))
                bulunanHarfler.Add(ch);
        }

        bulunanHarfler.Sort();

        Console.WriteLine("\nCümledeki sesli harfler (sıralanmış): ");
        foreach (var harf in bulunanHarfler)
            Console.Write(harf + " ");

        Console.WriteLine($"\n\nToplam Sesli Harf Sayısı: {bulunanHarfler.Count}");
    }
}

