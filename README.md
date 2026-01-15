*İsnikea Stok Takip ve Satış Sistemi*

Fabrika/mağaza stok ve satış işlemlerini yöneten bir masaüstü uygulamasıdır. Bu proje, yöneticilerin ve personelin ürün takibini, anlık satış işlemlerini, stok durumlarını ve finansal raporlamayı kolaylıkla yönetebileceği bir platform sunar.

📌*Proje Özellikleri*
Giriş ve Yetkilendirme: Kullanıcı girişi ve yönetici/personel yetki kontrolü.

Ürün Yönetimi: Sisteme yeni ürün ekleme, fiyat güncelleme ve silme işlemleri.

Stok Takibi: Ürünlerin anlık stok miktarlarını görme, kritik stok takibi ve yönetimi.

Satış İşlemleri: Barkod ile sepete ürün ekleme ve satış gerçekleştirme.

Finansal Raporlar: Günlük ciro, toplam satış ve kâr-zarar durumunun görüntülenmesi.


📂*Kullanılan Teknolojiler*
C# (.NET Framework)

Windows Forms (Masaüstü Arayüz)

MySQL (Veritabanı)

N-Katmanlı Mimari (DAL, BLL, UI)

Entity Design Pattern

*DİYAGRAM*

<img width="738" height="676" alt="Diyagram-1" src="https://github.com/user-attachments/assets/86a49f9e-7900-4789-91ed-c754b2fd2609" />



📸 *Ekran Görüntüleri*
<img width="1253" height="901" alt="Ekran görüntüsü 2026-01-15 114533" src="https://github.com/user-attachments/assets/c6a88d52-879f-4528-afa5-ed1bb4f55995" />
<img width="1368" height="824" alt="Ekran görüntüsü 2026-01-15 120124" src="https://github.com/user-attachments/assets/fed62cc1-72c9-45d8-8bc1-989c8e372694" />
<img width="1351" height="823" alt="Ekran görüntüsü 2026-01-15 120132" src="https://github.com/user-attachments/assets/4d6421e1-11f1-4d7c-aa10-09494b90eafb" />
Giriş kısmında girilen KullanıcıID numaaralarına göre açılan ekranlarda "Depo Yönetimi" bölümü görsellerde görüldüğü gibi işlemektedir. 
Ürün ekle, ürün listele, stok ekle, ürün sil, ürün güncelle işlemleri ile tabloya işlenen verilerin gösterimleri. 


<img width="1258" height="910" alt="Ekran görüntüsü 2026-01-15 120203" src="https://github.com/user-attachments/assets/b68f47e2-7ba1-4527-8127-56db2936e7c7" />
<img width="1005" height="746" alt="Ekran görüntüsü 2026-01-15 120308" src="https://github.com/user-attachments/assets/43209d21-2c26-47d0-8aae-aa32f64227cf" />
<img width="1007" height="753" alt="Ekran görüntüsü 2026-01-15 120256" src="https://github.com/user-attachments/assets/900edd78-65f8-4189-9133-3ec0206adb48" />
Giriş kısmında girilen KullanıcıID numaaralarına göre açılan ekranlarda "Satış Takip" bölümü görsellerde görüldüğü gibi işlemektedir. 
En sağdaki tablodan gördüğümüz üzere olan stoklara soldaki panelden ürünlerimizi sepete ekleyip sağdaki işlem kısmından satışı gerçekleştirebiliriz.
Satış sonrası stoklar güncellenmektedir.
Yapılan satış sonrası satılan ürün bilgileri,elde edilen kazanç ve stok bilgileri ise "Ynetici" bölümüne aktarılmaktadır.

<img width="1250" height="895" alt="Ekran görüntüsü 2026-01-15 120329" src="https://github.com/user-attachments/assets/c2aa1075-983f-4be2-b7e9-539fb6ab60a3" />
<img width="968" height="726" alt="Ekran görüntüsü 2026-01-15 120345" src="https://github.com/user-attachments/assets/bf8d772b-8fba-4852-b06e-0eb3e24d5a5d" />
<img width="971" height="744" alt="Ekran görüntüsü 2026-01-15 120414" src="https://github.com/user-attachments/assets/f687032f-cd27-40b2-8b16-bef6c19dcf02" />
<img width="979" height="747" alt="Ekran görüntüsü 2026-01-15 120428" src="https://github.com/user-attachments/assets/73220168-fd4e-4d01-bf44-b93dc6fc7ebc" />
<img width="968" height="726" alt="Ekran görüntüsü 2026-01-15 120345" src="https://github.com/user-attachments/assets/edf34ca8-e3b6-43cc-997e-9b24ea21af44" />
<img width="697" height="704" alt="image" src="https://github.com/user-attachments/assets/5a46457d-5c7e-446f-9690-9d193dc608b8" />
Giriş kısmında girilen KullanıcıID numaaralarına göre açılan ekranlarda "Yönetici" bölümü görsellerde görüldüğü gibi işlemektedir.
Satış Takip bölümünde yapılan işlemlerin bilgileri Yöneticiye aktarılır.
Gün olarak raporlanan sistemimiz tarih değiştikçe verilerini de o günkü tarihe göre değiştirmektedir.
Raporlama ekranında aynı zamanda günlük ciro , günlük kar , stokta mevcudiyet gösteren ürünler, stoğu kritik ürünler ve artık stokta bulunmayan ürünlerde listelenmektedir.
En sağdaki tablomuz ise seçilen tarihe göre satılan ürünlerin bilgilerini bize aktarmaktadır.









































🛠️ Proje Yapısı
DAL (Data Access Layer): Veritabanı işlemleri.

BLL (Business Logic Layer): İş mantığı.

UI (User Interface): Windows Forms kullanıcı arayüzü.

MySQL: Veritabanı bağlantı ve sorguları.

🎯 Proje Hedefleri
Operasyonel Dijitalleşme: Fabrika/mağaza stok ve satış süreçlerini kağıt ortamından kurtarıp dijitalleştirerek insan hatasını en aza indirmek.

Hızlı Satış: Barkod sistemi entegrasyonu ile satış işlemlerini hızlandırmak.

Etkin Stok Yönetimi: Anlık stok takibi ve kritik stok uyarıları ile gereksiz stok maliyetlerini veya ürün yokluğunu önlemek.

Finansal Analiz: Günlük satış raporları ile işletmenin kâr-zarar durumunu anlık olarak analiz etmek.

Güvenli Veri Yönetimi: Yönetici ve personel yetkilendirmeleri ile sistem verilerinin güvenliğini ve kontrollü erişimini sağlamak.



*Youtube Video*
https://youtu.be/lQGn5CQyM5E

📞 İletişim
Herhangi bir sorunuz veya öneriniz varsa lütfen benimle iletişime geçin:

Ad: Kübra
Soyad: Aydın
E-posta: kaydiin1905@gmail.com
