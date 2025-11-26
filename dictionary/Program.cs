using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Dictionary tanımlama (Key: int, Value: string)
        Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

        // Eleman ekleme
        kullanicilar.Add(120, "Ayşe Yılmaz");
        kullanicilar.Add(121, "Aynı İlknur");
        kullanicilar.Add(122, "Adem Ardar");
        kullanicilar.Add(200, "Özcan Coşar");

        // Belli bir elemana erişim
        Console.WriteLine("***** Belli Elemanlara Erişim *****");
        Console.WriteLine(kullanicilar[121]);
        Console.WriteLine(kullanicilar[200]);

        Console.WriteLine("\n***** Tüm Kullanıcılar *****");
        foreach (var item in kullanicilar)
            Console.WriteLine(item);

        // Count (eleman sayısı)
        Console.WriteLine("\n***** Count *****");
        Console.WriteLine(kullanicilar.Count);

        // Contains (Anahtar veya Değer var mı?)
        Console.WriteLine("\n***** Contains *****");
        Console.WriteLine(kullanicilar.ContainsKey(121));   // True
        Console.WriteLine(kullanicilar.ContainsValue("Ayşe Yılmaz")); // True
        Console.WriteLine(kullanicilar.ContainsValue("Züriye Ürkmez")); // False

        // Remove (Anahtar ile silme)
        Console.WriteLine("\n***** Remove 122 *****");
        kullanicilar.Remove(122);

        foreach (var item in kullanicilar)
            Console.WriteLine(item);

             // Keys
        Console.WriteLine("\n***** Keys *****");
        foreach (var key in kullanicilar.Keys)
            Console.WriteLine(key);

        // Values
        Console.WriteLine("\n***** Values *****");
        foreach (var value in kullanicilar.Values)
            Console.WriteLine(value);
    }
}

