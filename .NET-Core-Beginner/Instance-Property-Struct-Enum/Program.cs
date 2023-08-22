using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayşe", "Yılmaz", "IK");  //nesne
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Toplam Sonucu: {0}", Islemler.Topla(32, 19));
            Console.WriteLine("Toplam Sonucu: {0}", Islemler.Çıkar(35, 10));
            Console.WriteLine("-----------------------");
            Islemler3.secondMain(args);
            Console.WriteLine("-----------------------");
            Struct testStruct;
            testStruct.x = 15;
            Console.WriteLine(testStruct.x);
            Console.WriteLine(Months.April);
        }
    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Çıkar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
    class Islemler3
    {
        public static void secondMain(string[] args)
        {
            test();
        }

        static void test()
        {
            int a = 1, b = 2;
            int top = a + b;
            Console.WriteLine(top);
        }
    }
    struct Struct //value stack 16byte
    {

        //public int x=0;    diff, according to class
        public int x; 

    }
    class Program2 //ref heap
    {
        public int x=0;
    }
    enum Months
    {
        Jenuary,February,March,April
    }
}