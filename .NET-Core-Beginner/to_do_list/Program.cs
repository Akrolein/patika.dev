using System.Collections;

class Program
{
    //Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

    // Negatif ve numeric olmayan girişleri engelleyin.
    // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
    // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

    static void Main(string[] args)
    {
        ArrayList asalSayilar = new ArrayList();
        ArrayList asalOlmayanSayilar = new ArrayList();

        Console.WriteLine("20 Adet sayı giriniz.");

        for (int i = 0; i < 10; i++)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int sayi))
            {
                if (asalKontrol(sayi))
                {
                    Console.WriteLine(sayi + " asal bir sayıdır.");
                    asalSayilar.Add(sayi);
                }
                else
                {
                    Console.WriteLine(sayi + " asal bir sayı değildir.");
                    asalOlmayanSayilar.Add(sayi);
                }
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Geçersiz giriş: Negatif sayı girdiniz.");
                i--;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş: Sayısal olmayan bir değer girdiniz.");
                i--;
            }
        }

        asalSayilar.Reverse();
        asalOlmayanSayilar.Reverse();
        Console.WriteLine("Asal Sayılar:");
        foreach (var asalsayilar in asalSayilar)
        {
            Console.WriteLine(asalsayilar);
        }

        int toplam_asal = 0;
        foreach (int asalsayilar in asalSayilar)
        {
            toplam_asal += asalsayilar;
        }

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Asal Olmayan Sayılar:");
        foreach (var asalolmayansayilar in asalOlmayanSayilar)
        {
            Console.WriteLine(asalolmayansayilar);
        }

        int toplam_noasal = 0;
        foreach (int asalolmayansayilar in asalOlmayanSayilar)
        {
            toplam_noasal += asalolmayansayilar;
        }

        Console.WriteLine("Asal Sayıların Eleman Sayısı: " + asalSayilar.Count);
        Console.WriteLine("Asal Olmayan Sayıların Eleman Sayısı: " + asalOlmayanSayilar.Count);
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Asal Sayıların Ortalaması: " + toplam_asal/asalSayilar.Count);
        Console.WriteLine("Asal Olmayan Sayıların Ortalaması: "+toplam_noasal/asalOlmayanSayilar.Count);

    }

    static bool asalKontrol(int sayi)
    {
        if (sayi <= 1)
            return false;

        if (sayi <= 3)
            return true;

        if (sayi % 2 == 0 || sayi % 3 == 0)
            return false;

        for (int i = 5; i * i <= sayi; i += 6)
        {
            if (sayi % i == 0 || sayi % (i + 2) == 0)
                return false;
        }

        return true;
    }
}