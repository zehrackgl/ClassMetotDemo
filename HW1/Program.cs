using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Zehra";
            musteri1.Soyad = "Açıkgül";
            musteri1.Yas = 19;
            musteri1.Id = "12345678910";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Kübra";
            musteri2.Soyad = "Açıkgül";
            musteri2.Yas = 26;
            musteri2.Id = "01987654321";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Yas);
                Console.WriteLine(musteri.Id);

                Console.WriteLine("--------------------------------");
            }

            Console.WriteLine("----> Methotlar <----");

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ara(musteri2);
            musteriManager.MesajGonder(musteri1);
            musteriManager.Sil(musteri2);


            
        }
    }
}
