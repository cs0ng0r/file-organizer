# Fájl Rendező Program

Ez a program célja, hogy egy adott könyvtárban lévő fájlokat a fájl kiterjesztéseik alapján rendszerezze. A fájlok egy új, a kiterjesztésükkel megegyező nevű almappába kerülnek.

## Funkcionalitás

- A program ellenőrzi, hogy a megadott könyvtár létezik-e.
- A fájlokat a kiterjesztéseik alapján csoportosítja (pl. `.txt`, `.jpg`, `.pdf`).
- Ha egy fájlnak nincs kiterjesztése, azt "egyeb" mappába helyezi.
- Az almappák automatikusan létrejönnek, ha még nem léteznek.

## Használat

1. Klónozd vagy töltsd le a repository-t.
2. Nyisd meg a `Program.cs` fájlt a Visual Studio vagy bármely más C#-fejlesztői környezetben.
3. A `Main` függvény indítja el a programot, amely kérni fogja a rendezendő könyvtár elérési útját.
4. Add meg a könyvtár elérési útját, majd a program elkezdi a fájlok rendezését.
5. A fájlok a megfelelő almappákba kerülnek a kiterjesztéseik alapján.

## Példa

Ha van egy könyvtár, amelyben a következő fájlok találhatóak:

- `dokumentum1.pdf`
- `kep1.jpg`
- `feljegyzes.txt`
- `ismeretlen`

A program a következő mappákat hozza létre:

```
- pdf
    - dokumentum1.pdf
- jpg
    - kep1.jpg
- txt
    - feljegyzes.txt
- egyeb
    - ismeretlen
```

## Telepítés

1. Másold be a `Program.cs` fájlt a projektedbe, vagy hozz létre egy új C# konzolos projektet és illeszd be a kódot.
2. A projekt futtatásához szükséges a .NET SDK telepítése. [Itt letöltheted a legfrissebb verziót](https://dotnet.microsoft.com/download).
