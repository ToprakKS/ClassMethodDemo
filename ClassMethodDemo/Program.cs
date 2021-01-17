using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 10;
            musteri1.Name = "Toprak";
            musteri1.LastName = "Kaan";
            musteri1.Address = "Antalya";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 11;
            musteri2.Name = "Ahmet";
            musteri2.LastName = "Şimşek";
            musteri2.Address = "Ankara";


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            Console.WriteLine("                   ");
            musteriManager.MusteriSil(musteri1);
            Console.WriteLine("                   ");
            musteriManager.MusteriEkle(musteri2);
            Console.WriteLine("                   ");
            musteriManager.MusteriSil(musteri2);
            Console.WriteLine("                   ");
            musteriManager.MusteriListele(musteri1);
            Console.WriteLine("                   ");
            musteriManager.MusteriListele(musteri2);

        }
    }
}
