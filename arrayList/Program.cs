using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        ArrayList Liste = new ArrayList();
        Liste.Add("Ayşe");
        Liste.Add(2);
        Liste.Add(true);
        Liste.Add('A');

        Console.WriteLine("***** İlk Liste *****");
        foreach (var item in Liste)
            Console.WriteLine(item);

        Console.WriteLine("\n***** Add Range *****");
        string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
        List<int> sayilar = new List<int>() { 1, 3, 8, 7, 9, 2, 5 };
        Liste.AddRange(renkler);
        Liste.AddRange(sayilar);

        foreach (var item in Liste)
            Console.WriteLine(item);

        Console.WriteLine("\n***** Sort *****");
        sayilar.Sort();
        foreach (var item in sayilar)
            Console.WriteLine(item);

        Console.WriteLine("\n***** Binary Search *****");
        int index = sayilar.BinarySearch(9);
        Console.WriteLine("9'un indexi: " + index);

        Console.WriteLine("\n***** Reverse *****");
        sayilar.Reverse();
        foreach (var item in sayilar)
            Console.WriteLine(item);

        Console.WriteLine("\n***** Clear *****");
        Liste.Clear();
        foreach (var item in Liste)
            Console.WriteLine(item);
    }
}
