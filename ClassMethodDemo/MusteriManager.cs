using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : " + musteri.Name + " " + musteri.LastName);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : " + musteri.Id);
        }

        public void MusteriListele(Musteri musteri)
        {
            
            Console.WriteLine("Müşteri Listesi : "+"\n ID : " + musteri.Id +"\n İsmi : "+ musteri.Name + "\n Soyismi : " + musteri.LastName + "\n Adresi : " + musteri.Address);

        }
    }
}
