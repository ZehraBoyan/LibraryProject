# Kütüphane Otomasyon Sistemi

Bu proje, kitap ödünç alma ve iade işlemlerini yönetmek için bir kütüphane otomasyon sistemi sağlar. C# programlama dili kullanılarak geliştirilmiş ve nesne yönelimli programlama (OOP) prensiplerine uygun olarak tasarlanmıştır. EF Core Code First yaklaşımı ile yapılmıştır.

## Özellikler

- Kütüphanede farklı türlerde kitaplar bulunmaktadır (bilim, roman, tarih vb.).
- Kütüphaneye üye olan herkes kütüphane stoğundaki kitapları ödünç alabilir.
- Bir üye kitap ödünç alabilir ve iade edebilir.
- Kitapların mevcut durumu güncellenebilir (ödünç alınabilir, ödünçte, mevcut değil).
- Bir üyenin ödünç aldığı kitaplar görüntülenebilir.
- Kütüphane durumu (mevcut kitaplar, ödünç alınan kitaplar, üyeler vb.) görüntülenebilir.

## Proje Yapısı

Projemiz altı temel bileşenden oluşmaktadır:

- **Kitap**: Kitapların temel özelliklerini içerir. Bu sınıf, diğer kitap türleri için temel görevi görür.
- **KitapBilim**, **KitapRoman**, **KitapTarih**: Farklı kitap türlerine özgü özellikleri tanımlar.
- **IUye**: Üye sınıfının özelliklerini ve işlevlerini belirten bir arayüz.
- **Uye**: Kütüphaneye üye olan kişilerin özelliklerini ve metotlarını uygular.
- **Kutuphane**: Kitapları ve üyeleri yöneten ana sınıf. Kitap ödünç alma, iade etme, mevcut durumu güncelleme gibi işlemleri gerçekleştirir.

## Nasıl Kullanılır?

Projeyi kullanmak için aşağıdaki adımları izleyebilirsiniz:

1. Dosyayı Visual Studio veya Visual Studio Code gibi bir geliştirme ortamında açın.
2. Projeyi derleyin ve çalıştırın.
3. Konsol ekranında, kütüphane otomasyon sisteminin sunduğu işlevleri kullanarak kitap ödünç alma, iade etme, kitapları listeleme vb. işlemleri gerçekleştirin.

