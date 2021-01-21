using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

                Musteri musteri1 = new Musteri();
                musteri1.Id = 1;
                musteri1.isim = "Eren ";
                musteri1.soyisim = "Sabah";
                musteri1.yas = 30;

                Musteri musteri2 = new Musteri();
                musteri2.Id = 2;
                musteri2.isim = "Rabia";
                musteri2.soyisim = "Kantar";
                musteri2.yas = 45;

                Musteri musteri3 = new Musteri();
                musteri3.Id = 3;
                musteri3.isim = "Ali";
                musteri3.soyisim = "Akşam";
                musteri3.yas = 44;

                Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

                MusteriManager musteriManager = new MusteriManager();

                musteriManager.Listele(musteriler);

                musteriManager.Ekle(musteri2);

                musteriManager.Sil(musteri3);

            }

        }
    }

