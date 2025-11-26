using System;

class Program
{
    static void Main(string[] args)
    {
     
        Console.WriteLine("***** DateTime Format *****");
        Console.WriteLine(DateTime.Now.ToString("dd"));     // Gün
        Console.WriteLine(DateTime.Now.ToString("ddd"));    // Kısa Gün
        Console.WriteLine(DateTime.Now.ToString("dddd"));   // Uzun Gün

        Console.WriteLine(DateTime.Now.ToString("MM"));     // Ay
        Console.WriteLine(DateTime.Now.ToString("MMM"));    // Kısa Ay
        Console.WriteLine(DateTime.Now.ToString("MMMM"));   // Uzun Ay

        Console.WriteLine(DateTime.Now.ToString("yy"));     // 2 Haneli Yıl
        Console.WriteLine(DateTime.Now.ToString("yyyy"));   // 4 Haneli Yıl

        // ************** Math Kütüphanesi **************
        Console.WriteLine("\n***** Math Temel İşlemler *****");
        Console.WriteLine(Math.Abs(-25));
        Console.WriteLine(Math.Sin(10));
        Console.WriteLine(Math.Cos(10));
        Console.WriteLine(Math.Tan(10));

        Console.WriteLine(Math.Ceiling(22.3));
        Console.WriteLine(Math.Round(22.3));
        Console.WriteLine(Math.Round(22.7));
        Console.WriteLine(Math.Floor(22.7));

        // ************** Math: Max, Min, Pow, Sqrt, Exp, Log **************
        Console.WriteLine("\n***** Math Diğer Metotlar *****");
        Console.WriteLine(Math.Max(2, 6));
        Console.WriteLine(Math.Min(2, 6));

        Console.WriteLine(Math.Pow(3, 4));      // 3^4 = 81
        Console.WriteLine(Math.Sqrt(81));       // Karekök

        Console.WriteLine(Math.Exp(3));         // e^3
        Console.WriteLine(Math.Log(10));        // ln(10)
        Console.WriteLine(Math.Log10(10));      // log10(10) = 1

        Console.ReadLine(); // Konsol kapanmasın

    }
}


