using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repositories
{
    public interface IKitapRepository
    {
        // Tüm kitapları getir
        List<Kitap> TumKitaplariGetir();

        // ISBN numarasına göre kitap getir
        Kitap KitapGetir(string isbn);

        // Yeni bir kitap ekler
        void KitapEkle(Kitap kitap);

        // Var olan bir kitabı günceller
        void KitapGuncelle(Kitap kitap);

        // Bir kitabı kütüphaneden kaldırır
        void KitapSil(string isbn);
    }
}
