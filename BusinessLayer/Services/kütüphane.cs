namespace LibraryAutomationSystem.Services
{
    using BusinessLayer.Repositories;
    using System;
    using System.Collections.Generic;

    public class Kutuphane
    {
        private List<Kitap> kitaplar = new List<Kitap>();
        private List<Uye> uyeler = new List<Uye>();
        public List<Uye> Uyeler
        {
            get { return uyeler; }
        }
        public List<Kitap> Kitaplar
        {
            get { return kitaplar; }
        }

        public void KitapEkle(Kitap kitap)
        {
            kitaplar.Add(kitap);
        }

        public void UyeEkle(Uye uye)
        {
            uyeler.Add(uye);
        }

        public void KitaplariGoruntule()
        {
            Console.WriteLine("Kütüphanedeki kitaplar:");
            foreach (var kitap in kitaplar)
            {
                kitap.DisplayInfo();
            }
        }

        public void UyeleriGoruntule()
        {
            Console.WriteLine("Kütüphaneye kayıtlı üyeler:");
            foreach (var uye in uyeler)
            {
                Console.WriteLine($"- {uye.Ad} {uye.Soyad}");
            }
        }
    }

}
