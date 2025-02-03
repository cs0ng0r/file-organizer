using System;
using System.IO;

class Program
{
    static void RendezFajlok(string konyvtar)
    {
        if (!Directory.Exists(konyvtar))
        {
            Console.WriteLine($"A '{konyvtar}' könyvtár nem létezik.");
            return;
        }

        foreach (var fajl in Directory.GetFiles(konyvtar))
        {
            string fajlNev = Path.GetFileName(fajl);
            string fajlKiterjesztes = Path.GetExtension(fajl).ToLower().TrimStart('.');

            if (string.IsNullOrEmpty(fajlKiterjesztes))
                fajlKiterjesztes = "egyeb";

            string mappaUt = Path.Combine(konyvtar, fajlKiterjesztes);

            if (!Directory.Exists(mappaUt))
            {
                Directory.CreateDirectory(mappaUt);
            }

            string ujFajlUt = Path.Combine(mappaUt, fajlNev);
            File.Move(fajl, ujFajlUt);
        }

        Console.WriteLine("A fájlok sikeresen rendezve!");
    }

    static void Main(string[] args)
    {
        Console.Write("Adja meg a rendezendő könyvtárat: ");
        string celKonyvtar = Console.ReadLine();
        RendezFajlok(celKonyvtar);
    }
}
