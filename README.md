# C# Kütüphane Otomasyon Programı
 ## Hakkında
 Bu proje kütüphanelerin kitap kayıt işlemleri, okuyucu kayıt işlemleri ve ödünç al - ver işlemlerini kolaylaştırmak için yapılmıştır.
 ### Özellikler
 * Kamera ile ISBN okutma ve Google Books veritabanından kitap bilgilerini çekerek kitap bilgilerini otomatik doldurma
 * Kolay ödünç takip sistemi
 * Bilgileri veritabanına gerçek zamanlı kayıt etme
 * Alınacak - Gecikmiş - Bugün alınacak - Alındı durumları için kolayca anlaşılabilir renklendirme
 * Kolayca yapılabilen Kitap silme - Kitap düzenleme - Kişi silme - Kişi düzenleme işlemleri
 * Kolay taşınabilirlik : ```data.db``` dosyasını başka bilgisayarda bulunan ```KOP.exe```'nin bulunduğu kalsöre atarak bilgilere erişme
 * Veritabanını şifreleme (EKLENECEK)
 ## Nasıl Kullanılır
 ```Kütüphane Otomasyon Programı Build``` klasörünün içerisindeki ```KOP.exe``` adlı dosyayı çalıştırarak programı kullanabilirsiniz.

 Veya ```Kütüphane Programı``` klasörünün içerisindeki ```KütüphaneOtomasyonProgramı.sln``` adlı dosyayı ```Visual Studio``` programı ile açarak hem kaynak kodlarını inceleyebilir hem de programı kullanabilirsiniz.
 ## Ekran Görüntüleri

<img src=Screenshots/screenshot1.png width="400" height="200"/>

<img src=Screenshots/screenshot2.png width="400" height="200"/>

<img src=Screenshots/screenshot3.png width="400" height="200"/>

<img src=Screenshots/screenshot4.png width="400" height="200"/>

<img src=Screenshots/screenshot5.png width="400" height="200"/>

<img src=Screenshots/ReadBarcode.gif width="400" height="200"/>

 ## Kullanılan Teknolojiler
 [.NET](https://dotnet.microsoft.com/en-us/)

 [AForge](https://www.nuget.org/packages/AForge/2.2.5?_src=template)

 [Google Books API](https://developers.google.com/books)

 [ZXing .NET](https://www.nuget.org/packages/ZXing.Net/0.16.8?_src=template)

 [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/13.0.1?_src=template)

 [SQLite](https://www.sqlite.org/index.html)
 ## Gereksinimler
 [.NET Framework v4.7.2](https://dotnet.microsoft.com/en-us/tr-tr/download/dotnet-framework/net472)
 ## Lisans
 [MIT](https://choosealicense.com/licenses/mit/)