# pet-simulator
🐾 Sanal Hayvan Sahiplenme ve Bakım Sistemi
Bu proje, C# Windows Forms kullanılarak geliştirilmiş, nesne yönelimli programlama (OOP) prensiplerini temel alan bir sanal bebek (pet simülasyonu) uygulamasıdır. Kullanıcılar kedi veya köpek sahiplenebilir, onların ihtiyaçlarını (açlık, enerji, mutluluk) takip edebilir ve gelişimlerini izleyebilirler.

🚀 Özellikler
Kullanıcı & Admin Girişi: Sisteme kullanıcı veya yönetici (admin) rolüyle giriş yapılabilir.

Hayvan Sahiplenme: İsim vererek kedi veya köpek sahiplenme mekanizması.

Dinamik İhtiyaç Takibi: * Besleme: Açlık barını doldurur.

Oynat: Mutluluk barını artırırken enerji tüketir.

Uyut: Enerji barını yeniler.

Gerçek Zamanlı Gelişim: Timer kontrolü ile hayvanın yaşlanması ve ihtiyaçlarının zamanla azalması.

Ruh Hali Sistemi: Hayvanın bar değerlerine göre "Kritik", "Normal" veya "Mutlu" olduğunu gösteren durum göstergesi.

Admin Paneli: Sahiplenilen tüm hayvanların ve sahiplerinin listelendiği yönetim ekranı.

🛠️ Teknik Mimari (OOP Prensipleri)
Proje, akademik standartlara uygun olarak şu prensipler üzerine inşa edilmiştir:

Abstract Class (Soyut Sınıf): pet sınıfı temel özellikleri barındıran bir şablon olarak kullanılmıştır.

Inheritance (Kalıtım): kediclass ve köpekclass sınıfları pet sınıfından türetilmiştir.

Interface (Arayüz): Hayvan etkileşimleri IHayvanEtkilesimi interface'i ile standartlaştırılmıştır.

Encapsulation (Kapsülleme): Hayvanların barları 0-100 arasında sınırlandırılarak güvenli veri kontrolü sağlanmıştır.
