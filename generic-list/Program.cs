using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> - Sayı listesi
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            // List<string> - Renk listesi
            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            Console.WriteLine("--- Liste Eleman Sayısı ---");
            Console.WriteLine("Renk Listesi: " + renkListesi.Count);
            Console.WriteLine("Sayı Listesi: " + sayiListesi.Count);

            Console.WriteLine("\n--- Foreach ile Liste Elemanları ---");
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);

            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            Console.WriteLine("\n--- List.ForEach ile Yazdırma ---");
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Listeden eleman silme
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            Console.WriteLine("\n--- Silme Sonrası ---");
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Liste içinde arama
            if (sayiListesi.Contains(10))
                Console.WriteLine("\n10 liste içinde bulundu!");

            // Eleman ile index bulma
            Console.WriteLine("Turuncu index: " + renkListesi.BinarySearch("Turuncu"));

            // Diziyi listeye dönüştürme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);

            hayvanListesi.Clear(); // Listeyi temizler

            // Nesne listesi kullanımı (Class Kullanımı)
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar()
            {
                Isim = "Ayşe",
                Soyisim = "Yılmaz",
                Yas = 26
            };

            Kullanicilar kullanici2 = new Kullanicilar()
            {
                Isim = "Deniz",
                Soyisim = "Demir",
                Yas = 24
            };

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            // Tek satırda nesne oluşturup ekleme
            kullaniciListesi.Add(new Kullanicilar()
            {
                Isim = "Mehmet",
                Soyisim = "Arda",
                Yas = 30
            });

            Console.WriteLine("\n--- Kullanıcı Listesi ---");
            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanici.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı: " + kullanici.Yas);
                Console.WriteLine("----------------------");
            }

            Console.ReadLine();
        }
    }

    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
