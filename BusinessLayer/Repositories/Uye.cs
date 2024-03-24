using BusinessLayer.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.Repositories
{
    public class Uye : IUye
    {
        [Key] public int Id { get; set; }
        public string Ad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Soyad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int UyeNo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
      

        public void KitapIadeEt(Kitap kitap)
        {
            throw new NotImplementedException();
        }

        public void KitapOduncAl(Kitap kitap)
        {
            throw new NotImplementedException();
        }

        public void OduncAlinanKitaplariGoruntule()
        {
            throw new NotImplementedException();
        }
    }
}