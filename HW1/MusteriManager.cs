using System;
using System.Collections.Generic;
using System.Text;

namespace HW1
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Sisteme müşteri eklendi");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Sistemden müşteri silindi");
        }
        public void Ara(Musteri musteri)
        {
            Console.WriteLine("Müşteri arandı : " + musteri.Ad);
        }
        public void MesajGonder(Musteri musteri)
        {
            Console.WriteLine("Müşteriye mesaj gönderildi : " + musteri.Id);
        }
    }
}
