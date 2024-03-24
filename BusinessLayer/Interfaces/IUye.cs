using BusinessLayer.Repositories;

namespace BusinessLayer.Interfaces
{
    public interface IUye
    {
        string Ad { get; set; }
        string Soyad { get; set; }
        int UyeNo { get; set; }
        void KitapOduncAl(Kitap kitap);
        void KitapIadeEt(Kitap kitap);
        void OduncAlinanKitaplariGoruntule();
    }
}
