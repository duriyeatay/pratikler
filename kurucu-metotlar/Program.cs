using System;

namespace KurucuMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Çalışan 1 *****");
            Calisan calisan1 = new Calisan("Ayşe", "Kara", 2345634, "İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine("\n***** Çalışan 2 *****");
            Calisan calisan2 = new Calisan("Deniz", "Arda", 2564870, "Satın Alma");
            calisan2.CalisanBilgileri();

            Console.WriteLine("\n***** Çalışan 3 (Parametresiz Constructor ile) *****");
            Calisan calisan3 = new Calisan();
            calisan3.Ad = "Mert";
            calisan3.Soyad = "Yılmaz";
            calisan3.No = 4789652;
            calisan3.Departman = "Bilgi İşlem";
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        // Parametreli Constructor
        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        // Parametresiz Constructor
        public Calisan() { }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
        }
    }
}

