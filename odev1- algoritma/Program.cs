using System;

class Program
{
    static void Main(string[] args)
    {
        // ****************** 1. Soru ******************
        Console.WriteLine("1) Pozitif bir sayı giriniz (n): ");
        int n1 = int.Parse(Console.ReadLine());
        int[] sayilar1 = new int[n1];

        Console.WriteLine($"{n1} adet pozitif sayı giriniz:");
        for (int i = 0; i < n1; i++)
            sayilar1[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Çift sayılar:");
        foreach (var sayi in sayilar1)
            if (sayi % 2 == 0)
                Console.WriteLine(sayi);


        // ****************** 2. Soru ******************
        Console.WriteLine("\n2) Pozitif iki sayı giriniz (n ve m):");
        int n2 = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[] sayilar2 = new int[n2];

        Console.WriteLine($"{n2} adet pozitif sayı giriniz:");
        for (int i = 0; i < n2; i++)
            sayilar2[i] = int.Parse(Console.ReadLine());

        Console.WriteLine($"m'e eşit veya tam bölünen sayılar (m = {m}):");
        foreach (var sayi in sayilar2)
            if (sayi == m || sayi % m == 0)
                Console.WriteLine(sayi);


        // ****************** 3. Soru ******************
        Console.WriteLine("\n3) Pozitif bir sayı giriniz (n): ");
        int n3 = int.Parse(Console.ReadLine());
        string[] kelimeler = new string[n3];

        Console.WriteLine($"{n3} adet kelime giriniz:");
        for (int i = 0; i < n3; i++)
            kelimeler[i] = Console.ReadLine();

        Console.WriteLine("Kelimeler sondan başa doğru:");
        for (int i = kelimeler.Length - 1; i >= 0; i--)
            Console.WriteLine(kelimeler[i]);


        // ****************** 4. Soru ******************
        Console.WriteLine("\n4) Bir cümle yazınız:");
        string cumle = Console.ReadLine();

        string[] kelimeDizisi = cumle.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        int harfSayisi = 0;
        foreach (char c in cumle)
            if (char.IsLetter(c))
                harfSayisi++;

        Console.WriteLine($"Kelime sayısı: {kelimeDizisi.Length}");
        Console.WriteLine($"Harf sayısı: {harfSayisi}");
    }
}

