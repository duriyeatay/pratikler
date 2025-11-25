using System;

class Program
{
    static void Main(string[] args)
    {
        // Rekürsif – Öz yinelemeli
        // 3^4 = 3*3*3*3

        int result = 1;
        for (int i = 1; i <= 4; i++)
            result = result * 3;
        Console.WriteLine(result);

        Islemler instance = new Islemler();
        Console.WriteLine(instance.Expo(3, 4)); // Recursive çağrı

        // Extension Metotlar
        string ifade = "Zikriye Ürkmez Cengiz";
        Console.WriteLine(ifade);
    }
}

public class Islemler
{
    public int Expo(int sayi, int üs)
    {
        if (üs < 2)
            return sayi;
        return Expo(sayi, üs - 1) * sayi;

        // Expo(3,4) = 3 * Expo(3,3)
        // Expo(3,3) = 3 * Expo(3,2)
        // Expo(3,2) = 3
        // 3 * 3 * 3 * 3 = 81
    }
    
}
public static class Extension
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }

    public static string RemoveWhiteSpaces(this string param)
    {
        string[] dizi = param.Split(" ");
        return string.Join("", dizi);
    }

    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }

    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }

    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }
}

