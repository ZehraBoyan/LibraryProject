namespace LibraryAutomationSystem.Entites
{
    using BusinessLayer.Interfaces;
    using LibraryAutomationSystem.Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Uye 
    {
        [Key] public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int UyeNo { get; set; }
        private List<Kitap> oduncAlinanKitaplar = new List<Kitap>();

        public Uye(string ad, string soyad, int uyeNo)
        {
            Ad = ad;
            Soyad = soyad;
            UyeNo = uyeNo;
        }

        public void KitapOduncAl(Kitap kitap)
        {
            if (kitap.Durum == Durum.OduncAlabilir)
            {
                kitap.Durum = Durum.OduncVerildi;
                oduncAlinanKitaplar.Add(kitap);
                Console.WriteLine($"{kitap.Baslik} kitabı başarıyla ödünç alındı.");
            }
            else
            {
                Console.WriteLine($"{kitap.Baslik} kitabı şu anda ödünç alınamaz.");
            }
        }

        public void KitapIadeEt(Kitap kitap)
        {
            if (oduncAlinanKitaplar.Contains(kitap))
            {
                kitap.Durum = Durum.OduncVerildi;
                oduncAlinanKitaplar.Remove(kitap);
                Console.WriteLine($"{kitap.Baslik} kitabı başarıyla iade edildi.");
            }
            else
            {
                Console.WriteLine($"{kitap.Baslik} kitabı size ait değil.");
            }
        }

        public void OduncAlinanKitaplariGoruntule()
        {
            Console.WriteLine($"{Ad} {Soyad}'ın ödünç aldığı kitaplar:");
            foreach (var kitap in oduncAlinanKitaplar)
            {
                Console.WriteLine($"- {kitap.Baslik}");
            }
        }

      
    }

}
