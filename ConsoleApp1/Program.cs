using System;
using System.Collections.Generic;
using System.Linq;

namespace deneme
{
    class Program
    {
        public class Kayit
        {
            public int No { get; set; }
            public string Adi { get; set; }
            public string Soyadi { get; set; }
            public int Sinif { get; set; }
            public string Cinsiyet { get; set; }
            public DateTime DogumTarihi { get; set; }
            public int Yasi { get; set; }
            public int Kulup { get; set; }
            public int[] Notlar { get; set; }
            public double Ortalama { get; set; }
            public bool Basarili { get; set; }
            public int OkunanKitapSayisi { get; set; }
        }


        public class KulupKaydi
        {
            public int KayitNo { get; set; }
            public string Adi { get; set; }
            public string Sorumlu { get; set; }
        }


        public static List<Kayit> OgrencileriGetir()
        {
            List<Kayit> Ogrenciler = new List<Kayit>();
            Ogrenciler.Add(new Kayit()
            {
                No = 2,
                Adi = "Tuncay",
                Soyadi = "Çağrı",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(2002, 2, 27),
                Sinif = 4,
                Kulup = 0,
                OkunanKitapSayisi = 11,
                Notlar = new int[] { 75, 70, 75 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 4,
                Adi = "Jale",
                Soyadi = "İkinci",
                Cinsiyet = "Bayan",
                DogumTarihi = new DateTime(1970, 1, 28),
                Sinif = 3,
                Kulup = 1,
                OkunanKitapSayisi = 7,
                Notlar = new int[] { 100, 95, 97, 96 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 7,
                Adi = "Tekin",
                Soyadi = "Uğurlu",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1955, 3, 26),
                Sinif = 1,
                Kulup = 1,
                OkunanKitapSayisi = 4,
                Notlar = new int[] { 30, 40, 20 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 8,
                Adi = "Mesut",
                Soyadi = "Bahtiyar",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1980, 4, 25),
                Sinif = 4,
                Kulup = 1,
                OkunanKitapSayisi = 8,
                Notlar = new int[] { 70, 10, 30 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 12,
                Adi = "Veli",
                Soyadi = "Canlı",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1993, 5, 24),
                Sinif = 4,
                Kulup = 2,
                OkunanKitapSayisi = 8,
                Notlar = new int[] { 80, 40, 10 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 6,
                Adi = "Ahmet",
                Soyadi = "Geçe",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1958, 6, 23),
                Sinif = 2,
                Kulup = 2,
                OkunanKitapSayisi = 9,
                Notlar = new int[] { 70, 80, 80 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 15,
                Adi = "Fatma",
                Soyadi = "Teyze",
                Cinsiyet = "Bayan",
                DogumTarihi = new DateTime(1972, 7, 22),
                Sinif = 3,
                Kulup = 1,
                OkunanKitapSayisi = 12,
                Notlar = new int[] { 70, 98, 97, 92 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 14,
                Adi = "Mehmet",
                Soyadi = "Emre",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1970, 8, 21),
                Sinif = 4,
                Kulup = 0,
                OkunanKitapSayisi = 7,
                Notlar = new int[] { 80, 22, 97 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 3,
                Adi = "Hale",
                Soyadi = "Birinci",
                Cinsiyet = "Bayan",
                DogumTarihi = new DateTime(1982, 9, 20),
                Sinif = 2,
                Kulup = 1,
                OkunanKitapSayisi = 11,
                Notlar = new int[] { 20, 40, 10, 30 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 13,
                Adi = "Ayşe",
                Soyadi = "Hanım",
                Cinsiyet = "Bayan",
                DogumTarihi = new DateTime(1983, 10, 19),
                Sinif = 2,
                Kulup = 1,
                OkunanKitapSayisi = 5,
                Notlar = new int[] { 100, 40, 100 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 11,
                Adi = "Cevdet",
                Soyadi = "Döğer",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1967, 11, 18),
                Sinif = 3,
                Kulup = 2,
                OkunanKitapSayisi = 7,
                Notlar = new int[] { 20, 0, 30, 15 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 1,
                Adi = "Nuri",
                Soyadi = "Babayiğit",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1998, 12, 17),
                Sinif = 2,
                Kulup = 2,
                OkunanKitapSayisi = 6,
                Notlar = new int[] { 55, 75, 65 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 5,
                Adi = "Kenan",
                Soyadi = "Oran",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1961, 1, 16),
                Sinif = 1,
                Kulup = 0,
                OkunanKitapSayisi = 9,
                Notlar = new int[] { 50, 70, 80 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 9,
                Adi = "Lale",
                Soyadi = "Üçüncü",
                Cinsiyet = "Bayan",
                DogumTarihi = new DateTime(1990, 2, 15),
                Sinif = 3,
                Kulup = 0,
                OkunanKitapSayisi = 6,
                Notlar = new int[] { 20, 0, 30 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 10,
                Adi = "Erhan",
                Soyadi = "Erkanlı",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1958, 3, 14),
                Sinif = 1,
                Kulup = 1,
                OkunanKitapSayisi = 7,
                Notlar = new int[] { 90, 90, 90, 90 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 16,
                Adi = "Erhan",
                Soyadi = "Fidan",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1968, 4, 13),
                Sinif = 2,
                Kulup = 1,
                OkunanKitapSayisi = 8,
                Notlar = new int[] { 95, 70, 100, 80 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 17,
                Adi = "Erhan",
                Soyadi = "Çelik",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1978, 5, 12),
                Sinif = 3,
                Kulup = 1,
                OkunanKitapSayisi = 7,
                Notlar = new int[] { 90, 55, 90 }
            });

            foreach (var Ogrenci in Ogrenciler)
            {
                Ogrenci.Ortalama = Ogrenci.Notlar.Average();
                Ogrenci.Basarili = Ogrenci.Ortalama >= 55;
                Ogrenci.Yasi = DateTime.Now.Year - Ogrenci.DogumTarihi.Year;
            }

            return Ogrenciler;


        }


        public static List<KulupKaydi> KulupleriGetir()
        {
            List<KulupKaydi> Kulupler = new List<KulupKaydi>();
            Kulupler.Add(new KulupKaydi() { KayitNo = 0, Adi = "Gezi", Sorumlu = "Tanju Bülbül" });
            Kulupler.Add(new KulupKaydi() { KayitNo = 1, Adi = "Tiyatro", Sorumlu = "Metin Öztürk" });
            Kulupler.Add(new KulupKaydi() { KayitNo = 2, Adi = "Müzik", Sorumlu = "Nuri Sezer" });
            Kulupler.Add(new KulupKaydi() { KayitNo = 3, Adi = "Kitap", Sorumlu = "Kazım Ünlüol" });
            return Kulupler;
        }


        static void Main(string[] args)
        {
            /*var Ogrenciler = OgrencileriGetir();

            var OgrenciSoyadlari =
                from Ogrenci in Ogrenciler
                select Ogrenci.Soyadi;

            Console.WriteLine("Öğrencilerin soyadları :");
            foreach (var Soyad in OgrenciSoyadlari)
            {
                Console.WriteLine(Soyad);
            }
            Console.ReadLine();
            */
            /*
            var Ogrenciler = OgrencileriGetir();

            var Kulupler = KulupleriGetir();

            var UyeOlunanKulupler = from Ogrenci in Ogrenciler
                                    from Kulup in Kulupler
                                    where Kulup.KayitNo == Ogrenci.Kulup
                                    select new { Ogrenci.Adi, KulupAdi = Kulup.Adi };

            Console.WriteLine("Öğrenciler ve kulüpleri :");

            foreach (var Satir in UyeOlunanKulupler)
            {
                Console.WriteLine("{0}, {1} kulübüne üye.", Satir.Adi, Satir.KulupAdi);
            }
            Console.ReadLine();
            */
            /*
            var Ogrenciler = OgrencileriGetir();

            var Kulupler = KulupleriGetir();

            var UyeOlunanKulupler = from Ogrenci in Ogrenciler
                                    from Kulup in Kulupler
                                    where Ogrenci.Ortalama >= 85 && Kulup.KayitNo == Ogrenci.Kulup
                                    select new { Ogrenci.Adi, KulupAdi = Kulup.Adi };

            Console.WriteLine("Ortalaması pekiyi olan öğrenciler ve kulüpleri :");

            foreach (var Satir in UyeOlunanKulupler)
            {
                Console.WriteLine("{0}, {1} kulübüne üye.", Satir.Adi, Satir.KulupAdi);
            }
            Console.ReadLine();
            */

            /*
            var Ogrenciler = OgrencileriGetir();

            var OgrencilerinTumNotlari =
                    Ogrenciler.SelectMany(
                         (Ogrenci, Index) =>
                              Ogrenci.Notlar.Select(Notu => new {
                                  Sira = (Index + 1),
                                  Not = Notu
                              }
                                                   )
                                         );

            Console.WriteLine("Öğrencilerinin kayıt sırasına göre notları :");

            foreach (var Satir in OgrencilerinTumNotlari)
            {
                Console.WriteLine("{0}. sıradaki öğrencimizin bir notu {1}.",
                                  Satir.Sira, Satir.Not);
            }
            Console.ReadLine();
            */
            /*
            var Ogrenciler = OgrencileriGetir();

            var Ilk5Ogrenci = Ogrenciler.Take(5);

            Console.WriteLine("Listedeki ilk 5 öğrenci :");

            foreach (var Ogrenci in Ilk5Ogrenci)
            {
                Console.WriteLine("{0} {1}", Ogrenci.Adi, Ogrenci.Soyadi);
            }
            Console.ReadLine();
            */
            /*
            var Ogrenciler = OgrencileriGetir();

            var Ilk2TamNot = (from Ogrenci in Ogrenciler
                              from Not in Ogrenci.Notlar
                              where Not == 100
                              select new { Ogrenci.Adi, Not }).Take(2);

            Console.WriteLine("İlk 2 tam not :");

            foreach (var Satir in Ilk2TamNot)
            {
                Console.WriteLine("{0} {1}", Satir.Adi, Satir.Not);
            }
            Console.ReadLine();
            */
            /*
            var Ogrenciler = OgrencileriGetir();

            var Son2Ogrenci = (from Ogrenci in Ogrenciler
                               select Ogrenci).Skip(Ogrenciler.Count() - 3);

            Console.WriteLine("Listedeki son 2 öğrenci :");

            foreach (var Ogrenci in Son2Ogrenci)
            {
                Console.WriteLine("{0} {1}", Ogrenci.Adi, Ogrenci.Soyadi);
            }
            Console.ReadLine();
            */
            //ilk iki tam not alanlardan sonrakiler
            /*
            var Ogrenciler = OgrencileriGetir();

            var Ilk2DenSonrakiTamNotlar = (from Ogrenci in Ogrenciler
                                           from Not in Ogrenci.Notlar
                                           where Not == 100
                                           select new { Ogrenci.Adi, Not }).Skip(2);

            Console.WriteLine("İlk 2 tam nottan sonraki tam notlar :");

            foreach (var Satir in Ilk2DenSonrakiTamNotlar)
            {
                Console.WriteLine("{0} {1}", Satir.Adi, Satir.Not);
            }
            Console.ReadLine();
            *//*
            var Ogrenciler = OgrencileriGetir();

            var IlkBasarililar = Ogrenciler.TakeWhile(Ogrenci => Ogrenci.Ortalama >= 55);

            Console.WriteLine("İlk başarısız öğrenciye kadar öğrenciler :");

            foreach (var BasariliOgrenci in IlkBasarililar)
            {
                Console.WriteLine("{0} {1}, ortalaması : {2:0.00}", BasariliOgrenci.Adi, BasariliOgrenci.Soyadi, BasariliOgrenci.Ortalama);
            }
            Console.ReadLine();*/
              /*
              var Ogrenciler = OgrencileriGetir();

              var Ilk5Ogrenci = Ogrenciler.TakeWhile((Ogrenci, Index) => Index <= 4);

              Console.WriteLine("İlk 5 öğrenci :");

              foreach (var Ogrenci in Ilk5Ogrenci)
              {
                  Console.WriteLine("{0} {1}", Ogrenci.Adi, Ogrenci.Soyadi);
              }
              Console.ReadLine();*/

            /*
            var Ogrenciler = OgrencileriGetir();

            var SiraliOgrenciListesi = from Ogrenci in Ogrenciler
                                       orderby Ogrenci.Soyadi descending
                                       select Ogrenci;

            Console.WriteLine("Soyadina göre ters sıralı öğrenci listesi :");

            foreach (var Ogrenci in SiraliOgrenciListesi)
            {
                Console.WriteLine("{0} - {1} {2}", Ogrenci.No, Ogrenci.Adi, Ogrenci.Soyadi);
            }
            Console.ReadLine();
            */
            /*
            var Ogrenciler = OgrencileriGetir();

            var Siniflar = from Ogrenci in Ogrenciler
                           orderby Ogrenci.Sinif
                           group Ogrenci by Ogrenci.Sinif into Sinifi
                           select new { Sinif = Sinifi.Key, OgrenciSayisi = Sinifi.Count() };

            Console.WriteLine("Sınıf öğrenci sayıları :");

            foreach (var Satir in Siniflar)
            {
                Console.WriteLine("{0}. sınıfta {1} öğrenci var.", Satir.Sinif, Satir.OgrenciSayisi);
            }
            Console.ReadLine();
            */
            /*
            var Ogrenciler = OgrencileriGetir();
            var Siniflar = from Ogrenci in Ogrenciler
                           orderby Ogrenci.Sinif
                           group Ogrenci by Ogrenci.Sinif into SinifGroup
                           select SinifGroup;
            foreach(var BirSiniftakiler in Siniflar)
            {

                Console.WriteLine("{0}. sınıftaki öğrenciler :", BirSiniftakiler.Key);

                foreach (var Ogrenci in BirSiniftakiler)
                {
                    Console.WriteLine("{0} {1}", Ogrenci.Adi, Ogrenci.Soyadi);
                }
            }
            Console.ReadLine();
            *//*
            var Ogrenciler = OgrencileriGetir();

            var Siniflar = from Ogrenci in Ogrenciler
                           orderby Ogrenci.Sinif
                           group Ogrenci by Ogrenci.Ortalama >= 55 into BasariGrubu
                           select BasariGrubu;

            Console.WriteLine("Öğrencilerin Başarı Durumları...");

            foreach (var BasariGrubu in Siniflar)
            {

                Console.WriteLine("\n- {0} öğrenciler :", BasariGrubu.Key ? "Başarılı" : "Başarısız");

                foreach (var Ogrenci in BasariGrubu)
                {
                    Console.WriteLine("{0} {1} -> {2:0.00}", Ogrenci.Adi, Ogrenci.Soyadi, Ogrenci.Ortalama);
                }

            }
            Console.ReadLine();*//*
            var Ogrenciler = OgrencileriGetir();

            var CinsiyeteGoreSinifListeleri =
                    from Ogrenci in Ogrenciler
                    orderby Ogrenci.No
                    group Ogrenci by Ogrenci.Sinif into SinifGrubu
                    select new
                    {
                        SinifNo = SinifGrubu.Key,
                        SinifOgrencileri = from BuSiniftakiOgrenci in SinifGrubu
                                           orderby BuSiniftakiOgrenci.Cinsiyet
                                           group BuSiniftakiOgrenci by BuSiniftakiOgrenci.Cinsiyet into SinifCinsiyetGrubu
                                           select SinifCinsiyetGrubu
                    };

            Console.WriteLine("Cinsiyete Göre Gruplanmış Sınıf Öğrenci Listeleri...");

            foreach (var Sinif in CinsiyeteGoreSinifListeleri)
            {

                Console.WriteLine("\n{0}. sınıf öğrencileri :", Sinif.SinifNo);

                foreach (var OgrenciGrubu in Sinif.SinifOgrencileri)
                {
                    Console.WriteLine("{0} öğrenciler:", OgrenciGrubu.Key);
                    foreach (var Ogrenci in OgrenciGrubu)
                    {
                        Console.WriteLine("{0} - {1} {2}",
                                          Ogrenci.No,
                                          Ogrenci.Adi,
                                          Ogrenci.Soyadi);
                    }
                }
            }
            Console.ReadLine();
            */
                                 // IEqualityComparer iki tane parametre alır.equals ve GetHashCode
                                 /*int[] BaziRakamlar = new int[] { 1, 2, 2, 3, 4, 4, 5, 6, 6 };
                                 var TekraralariAt = BaziRakamlar.Distinct();
                                 foreach(var Sayi in TekraralariAt)
                                 {
                                     Console.WriteLine(Sayi);

                                 }
                                 Console.ReadLine();*//*

            var Ogrenciler = OgrencileriGetir();

            var BirinciSinavNotlari = from Ogrenci in Ogrenciler
                                      select Ogrenci.Notlar[0];
            var IkinciSinavNotlari = from Ogrenci in Ogrenciler
                                     select Ogrenci.Notlar[1];
            var birleşim = BirinciSinavNotlari.Union(IkinciSinavNotlari);
            foreach(var sayi in birleşim)
            {
                Console.WriteLine(sayi);
            }
            Console.ReadLine();*//*
            var Ogrenciler = OgrencileriGetir();

            var BasariliOgrencilerinBirinciSinavNotlari =
                                from Ogrenci in Ogrenciler
                                where Ogrenci.Basarili
                                select Ogrenci.Notlar[0];

            var BasarisizOgrencilerinBirinciSinavNotlari =
                                from Ogrenci in Ogrenciler
                                where !Ogrenci.Basarili
                                select Ogrenci.Notlar[0];

            var BasariyaGoreOrtakBirinciSinavNotlari =
                                BasariliOgrencilerinBirinciSinavNotlari.Intersect(BasarisizOgrencilerinBirinciSinavNotlari);

            Console.WriteLine("Başarılı ve başarısız öğrencilerin aldığı ortak 1. sınav notları :");

            foreach (var Notu in BasariyaGoreOrtakBirinciSinavNotlari)
            {
                Console.WriteLine(Notu);
            }
            Console.ReadLine();*/
                                 /*
                                 var Ogrenciler = OgrencileriGetir();
                                 var OgrenciNotlariSozlugu = Ogrenciler.ToDictionary(Ogrenci => Ogrenci.No);
                                 Kayit BirÖgrenciKaydi = OgrenciNotlariSozlugu[14];
                                 Console.WriteLine("{0},{1},{2}" ,BirÖgrenciKaydi.Adi, BirÖgrenciKaydi.Sinif, BirÖgrenciKaydi.DogumTarihi.Year);
                                 Console.ReadLine();*//*
            var Ogrenciler = OgrencileriGetir();

            var Siniflar = from Ogrenci in Ogrenciler
                           group Ogrenci by Ogrenci.Sinif into SinifGrubu
                           where SinifGrubu.Any(SiniftakiOgrenci => SiniftakiOgrenci.Cinsiyet == "Bayan")
                           select new { Sinif = SinifGrubu.Key, OgrenciSayisi = SinifGrubu.Count() };

            Console.WriteLine("Bayan öğrencisi olan sınıfların öğrenci sayıları :");

            foreach (var SinifBilgisi in Siniflar)
            {

                Console.WriteLine("Bayan öğrenci bulunan {0}. sınıfta {1} öğrenci var.", SinifBilgisi.Sinif, SinifBilgisi.OgrenciSayisi);

            }

            Console.ReadLine();*//*
            var Ogrenciler = OgrencileriGetir();

            var SiniflardakiEnDusukOrtalamaliOgrenciler =
                            from Ogrenci in Ogrenciler
                            group Ogrenci by Ogrenci.Sinif into SinifGrubu
                            let EnDusukOrtalama = SinifGrubu.Min(SiniftakiOgrenci => SiniftakiOgrenci.Ortalama)
                            select new
                            {
                                Sinif = SinifGrubu.Key,
                                EnDusukOrtalamaliOgrenciler = SinifGrubu.Where(Ogrenci => Ogrenci.Ortalama == EnDusukOrtalama)
                            };

            Console.WriteLine("Sınıflardaki en düşük ortalamalı öğrenciler.");

            foreach (var Satir in SiniflardakiEnDusukOrtalamaliOgrenciler)
            {
                Console.WriteLine("{0}. sınıftaki en düşük ortalamalı öğrenci ortalaması {1} olan {2} isimli öğrencidir.",
                                  Satir.Sinif,
                                  Satir.EnDusukOrtalamaliOgrenciler.First().Ortalama,
                                  Satir.EnDusukOrtalamaliOgrenciler.First().Adi);
            }
            Console.ReadLine();*//*
            double[] OndalikSayilar = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            double Carpim = OndalikSayilar.Aggregate((SonSonuc, SiradakiDiziElemani) => SonSonuc * SiradakiDiziElemani);

            Console.WriteLine("Dizideki sayıların çarpımı = {0}", Carpim);

            Console.ReadLine();*//*
            double BaslangicBakiyesi = 100.0;

            int[] CekilmekIstenenler = { 20, 10, 40, 50, 10, 70, 30 };

            double Bakiye =
                            CekilmekIstenenler.Aggregate(BaslangicBakiyesi,
                                                         (SonBakiye, SiradakiTutar) =>
                                                                (
                                                                 (SiradakiTutar <= SonBakiye) ?
                                                                 (SonBakiye - SiradakiTutar) :
                                                                  SonBakiye
                                                                )
                                                        );

            Console.WriteLine("Son kalan: {0}", Bakiye);

            Console.ReadLine();*//*
            var Kulupler = KulupleriGetir();

            var Ogrenciler = OgrencileriGetir();

            var OgrencilerVeKulupSorumlulari =
                from Ogrenci in Ogrenciler
                join Kulup in Kulupler on Ogrenci.Kulup equals Kulup.KayitNo
                select new { OgrenciAdi = Ogrenci.Adi, KulupAdi = Kulup.Adi, KulupSorumlusu = Kulup.Sorumlu };

            Console.WriteLine("Öğrenciler ve üye oldukları kulüplerin rehber öğretmenleri :");

            foreach (var Nesne in OgrencilerVeKulupSorumlulari)
            {
                Console.WriteLine("{0} isimli öğrenci {1} kulübüne üyedir. Kulübün rehber öğretmeni: {2}.",
                                  Nesne.OgrenciAdi,
                                  Nesne.KulupAdi,
                                  Nesne.KulupSorumlusu);
            }
            Console.ReadLine();*//*
            var Kulupler = KulupleriGetir();

            var Ogrenciler = OgrencileriGetir();

            var KuluplerVeOgrencileri =
                        from Kulup in Kulupler
                        join Ogrenci in Ogrenciler on Kulup.KayitNo equals Ogrenci.Kulup into KulupVeOgrencileri
                        select new
                        {
                            KulupVeOgrencileri = KulupVeOgrencileri,
                            OgrenciSayisi = KulupVeOgrencileri.Count(),
                            KulupAdi = Kulup.Adi
                        };

            foreach (var Satir in KuluplerVeOgrencileri)
            {

                Console.WriteLine("{0} kulübüne üye {1} öğrenci var. Öğrenciler :",
                                  Satir.KulupAdi,
                                  Satir.OgrenciSayisi);

                foreach (var a in Satir.KulupVeOgrencileri)
                {
                    Console.WriteLine(a.Adi);
                }

            }
            Console.ReadLine();*//*
            var Kulupler = KulupleriGetir();

            var Ogrenciler = OgrencileriGetir();

            var KuluplerVeOgrencileri =
                        from Kulup in Kulupler
                        join Ogrenci in Ogrenciler on Kulup.KayitNo equals Ogrenci.Kulup into KulupVeOgrencileri
                        from Ogrenci in KulupVeOgrencileri.DefaultIfEmpty()//boş olanlar için varsayılan değeri kullanıyor
                        select new
                        {
                            Ogrenci = Ogrenci == null ? "(Öğrenci yok)" : Ogrenci.Adi,
                            KulupAdi = Kulup.Adi
                        };

            foreach (var Satir in KuluplerVeOgrencileri)
            {
                Console.WriteLine("{0}, {1} kulübüne üye.", Satir.Ogrenci, Satir.KulupAdi);
            }
            Console.ReadLine();*/










        }
    }
}