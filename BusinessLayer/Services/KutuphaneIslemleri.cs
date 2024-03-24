using BusinessLayer.Repositories;
using LibraryAutomationSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class KutuphaneIslemleri
    {
        private Kutuphane kutuphane;

        public KutuphaneIslemleri(Kutuphane kutuphane)
        {
            this.kutuphane = kutuphane;
        }

        public void KitapVeUyeEkle()
        {
            // Kitapları oluştur
            Kitap bilimKitabi = new KitapBilim("123456789", "Kozmos", "Carl Sagan", 1980);
            Kitap romanKitabi = new KitapRoman("987654321", "Dune", "Frank Herbert", 1965);

            // Kitapları kütüphaneye ekle
            kutuphane.KitapEkle(bilimKitabi);
            kutuphane.KitapEkle(romanKitabi);

            // Üyeleri oluştur
            Uye uye1=new Uye();
            uye1.Ad = "Zehra";
            uye1.Soyad = "Boyan";
            uye1.UyeNo = 1;


            Uye uye2 = new Uye();
            uye2.Ad = "Fatih";
            uye2.Soyad = "Afşin";
            uye2.UyeNo = 2;

            // Üyeleri kütüphaneye ekle
            kutuphane.UyeEkle(uye1);
            kutuphane.UyeEkle(uye2);
        }

        public void IslemleriYap()
        {
            // Kitapları ve üyeleri görüntüle
            kutuphane.KitaplariGoruntule();
            kutuphane.UyeleriGoruntule();

            // Örnek bir ödünç alma işlemi
            Console.WriteLine("\n--- Ödünç Alma İşlemi ---");
            Uye uye1 = kutuphane.Uyeler[0]; // Örnek olarak ilk üyeyi alıyoruz
            Kitap bilimKitabi = kutuphane.Kitaplar[0]; // Örnek olarak ilk kitabı alıyoruz
            uye1.KitapOduncAl(bilimKitabi);
            uye1.OduncAlinanKitaplariGoruntule();

            // Örnek bir iade işlemi
            Console.WriteLine("\n--- İade İşlemi ---");
            uye1.KitapIadeEt(bilimKitabi);
            uye1.OduncAlinanKitaplariGoruntule();
        }
    }
}
