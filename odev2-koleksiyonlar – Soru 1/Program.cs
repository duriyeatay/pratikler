using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList asalSayilar = new ArrayList();
        ArrayList asalOlmayanlar = new ArrayList();

        int sayac = 0;
        while (sayac < 20)
        {
            Console.Write($"{sayac + 1}. sayıyı giriniz: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int sayi) && sayi > 0)
            {
                if (AsalMi(sayi))
                    asalSayilar.Add(sayi);
                else
                    asalOlmayanlar.Add(sayi);

                sayac++;
            }
            else
            {
                Console.WriteLine("Hatalı giriş! Pozitif bir sayı giriniz.");
            }
        }

        // Sıralama (Büyükten küçüğe)
        asalSayilar.Sort(); asalSayilar.Reverse();
        asalOlmayanlar.Sort(); asalOlmayanlar.Reverse();

        Console.WriteLine("\n--- Asal Sayılar ---");
        YazdirVeOrtalama(asalSayilar);

        Console.WriteLine("\n--- Asal Olmayan Sayılar ---");
        YazdirVeOrtalama(asalOlmayanlar);
    }

    static bool AsalMi(int sayi)
    {
        if (sayi == 1) return false;
        for (int i = 2; i <= Math.Sqrt(sayi); i++)
            if (sayi % i == 0)
                return false;
        return true;
    }

    static void YazdirVeOrtalama(ArrayList liste)
    {
        int toplam = 0;
        foreach (int item in liste)
        {
            Console.Write(item + " ");
            toplam += item;
        }
        Console.WriteLine($"\nEleman Sayısı: {liste.Count}");
        Console.WriteLine($"Ortalama: {(double)toplam / liste.Count}");
    }
}
