using System;

class Program
{
    static void Main()
    {
        int[] sayilar = new int[20];
        int sayac = 0;

        while (sayac < 20)
        {
            Console.Write($"{sayac + 1}. sayıyı giriniz: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int sayi))
            {
                sayilar[sayac] = sayi;
                sayac++;
            }
            else
            {
                Console.WriteLine("Hatalı giriş! Sayı giriniz.");
            }
        }

        Array.Sort(sayilar);

        int[] enKucuk = { sayilar[0], sayilar[1], sayilar[2] };
        int[] enBuyuk = { sayilar[17], sayilar[18], sayilar[19] };

        double ortKucuk = Ortalama(enKucuk);
        double ortBuyuk = Ortalama(enBuyuk);

        Console.WriteLine("\nEn Küçük 3 Sayı: " + string.Join(", ", enKucuk));
        Console.WriteLine("En Büyük 3 Sayı: " + string.Join(", ", enBuyuk));

        Console.WriteLine($"\nEn Küçüklerin Ortalaması: {ortKucuk}");
        Console.WriteLine($"En Büyüklerin Ortalaması: {ortBuyuk}");
        Console.WriteLine($"Ortalama Toplamı: {ortKucuk + ortBuyuk}");
    }

    static double Ortalama(int[] dizi)
    {
        int toplam = 0;
        foreach (var sayi in dizi)
            toplam += sayi;
        return (double)toplam / dizi.Length;
    }
}
