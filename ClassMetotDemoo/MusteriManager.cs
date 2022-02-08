using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {


        Musteri[] customers = new Musteri[] { };

        public void MusteriyiEkle(Musteri musteri)
        {
            customers = customers.Append(musteri).ToArray();
            Console.WriteLine(musteri.Adi + " müşterisi eklendi");
        }


        public void MusteriyiSil(Musteri musteri)
        {
            int index = Array.IndexOf(customers, musteri);
            List<Musteri> delcustomer = new List<Musteri>(customers);
            delcustomer.RemoveAt(index);
            customers = delcustomer.ToArray();
            Console.WriteLine(musteri.Adi + " müşterisi silindi");
        }


        public void MusteriyiListele()
        {
            foreach (var musteri in customers)
            {
                Console.WriteLine(" Adı: " + musteri.Adi + " Soyadı: " + musteri.Soyadi + " Telefonu: " + musteri.Telefon + " Adresi: " + musteri.Adres);
            }
        }
    }
}
