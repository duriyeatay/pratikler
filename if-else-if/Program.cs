using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 11)
                Console.WriteLine("Günaydın!");
            else if (time >= 11 && time < 18)
                Console.WriteLine("İyi Günler!");
            else
                Console.WriteLine("İyi Geceler!");

            // Ternary (?:) ile yazım
            string sonuc = time >= 6 && time < 11 ? "Günaydın!" :
                           time >= 11 && time < 18 ? "İyi Günler!" :
                           "İyi Geceler!";

            Console.WriteLine(sonuc);
        }
    }
}
