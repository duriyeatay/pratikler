using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // Çalışan 1 nesnesi
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 2345634;
            calisan1.Departman = "İnsan Kaynakları";
            calisan1.CalisanBilgileri();

            Console.WriteLine("***************");

            // Çalışan 2 nesnesi
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 2564870;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri();

            Console.WriteLine("***************");

            // Çalışan 3 nesnesi (ek örnek)
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

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            Console.WriteLine("Çalışanın Departman: {0}", Departman);
        }
    }
}

