using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
           // Dizi Tanımlama
string[] renkler = new string[5];
string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

int[] dizi;
dizi = new int[5];

// Dizilere Değer Atama ve Erişim
renkler[0] = "Mavi";
dizi[0] = 10;

Console.WriteLine(hayvanlar[3]);
Console.WriteLine(dizi[0]);
Console.WriteLine(renkler[0]);

// Döngülerle dizi kullanımı
Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
int diziUzunlugu = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[diziUzunlugu];
int sayi, toplam = 0;

for (int i = 0; i < diziUzunlugu; i++)
{
    Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
    sayiDizisi[i] = int.Parse(Console.ReadLine());
}

// Foreach ile toplama
foreach (var item in sayiDizisi)
    toplam += item;

Console.WriteLine("Ortalama = " + (toplam / diziUzunlugu));


        }
    }
}
