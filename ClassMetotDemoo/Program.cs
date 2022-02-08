using System;

namespace ClassMetotDemo
{
    class Program
    {   // 3.günün 3.Ödevi kısmı
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Kubilay";
            musteri1.Soyadi = "Kabakçı";
            musteri1.Adres = "Londra";
            musteri1.Telefon = "02121211414";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ahmet";
            musteri2.Soyadi = "Çalık";
            musteri2.Adres = "Madrid";
            musteri2.Telefon = "05412121212";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Melo";
            musteri3.Soyadi = "Felipe";
            musteri3.Adres = "İstanbul";
            musteri3.Telefon = "05442875859";

            Musteri musteri4 = new Musteri();
            musteri4.Adi = "Barış";
            musteri4.Soyadi = "Manço";
            musteri4.Adres = "Mersin";
            musteri4.Telefon = "05442875858";

            Musteri[] musteris = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            MusteriManager customerManager = new MusteriManager();

            customerManager.MusteriyiEkle(musteri1);
            customerManager.MusteriyiEkle(musteri2);
            customerManager.MusteriyiEkle(musteri3);
            customerManager.MusteriyiEkle(musteri4);


            customerManager.MusteriyiSil(musteri2);
            Console.WriteLine("Müşteri Listesi ");
            customerManager.MusteriyiListele();


        }
    }
}