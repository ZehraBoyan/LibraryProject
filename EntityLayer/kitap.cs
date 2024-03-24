using LibraryAutomationSystem.Enums;
using System.ComponentModel.DataAnnotations;

namespace LibraryAutomationSystem.Entites
{
  
    public abstract class Kitap
    {
        [Key] public int Id { get; set; }
        public string ISBN { get; set; }
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public int YayinYili { get; set; }
        public Durum Durum { get; set; }

        public Kitap(string isbn, string baslik, string yazar, int yayinYili)
        {
            ISBN = isbn;
            Baslik = baslik;
            Yazar = yazar;
            YayinYili = yayinYili;
            Durum = Durum.OduncAlabilir; // Başlangıç durumu mevcut olarak ayarlanıyor
        }

        public abstract void DisplayInfo();
    }

}
