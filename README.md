# ASP.NET Core 8.0 Dinamik Admin Ve Yazar Panelli Portfolio Sitesi

Bu proje, ASP.NET Core 8.0 sürümü ile hazırlanmış dinamik bir admin ve yazar paneline sahip bir portfolyo projesidir. Proje, dinamik yapıya sahip bir Çok Katmanlı Mimari (N-Tier Architecture) ve admin ile yazar paneli içermektedir.

-------------------------------------------------------------------------------------------------------------------

### Admin Panelinde;

- Veri tabanı tablolarında tüm dinamik CRUD işlemleri yapılabilmektedir. Yapılan işlemler eş zamanlı olarak portfolio sitesindeki görünüme yansır.

- İstatistik bilgilerini görebilme, gelen ve gönderilen mesajları inceleyebilme, mesaj gönderebilme ve okundu durumunu değiştirebilme özellikleri mevcuttur.

- Dashboard üzerindeki ToDo Listesi kullanımı ile görevleri yönetebilme ve tamamlanan işleri işaretleyebilme imkanı sağlanmaktadır.

- Admin Rol Ataması Sayesinde sadece rolü Admin olan kullanıcılar admin paneline giriş yapabilir.

- Admin üst menüden bildirimleri görebilir ve gelen mesajları görebilir
  
- Admin, Ajax ile Deneyim Sayfasında tüm veriler üzerinde ajax ile CRUD işlemlerini yapabilir
  
- Admin kendi panelinden, Yazar paneline ve Siteye giriş yapabilmektedir.
  
- Erişilemeyen sayfalar ve bulunamayan sayfalar için 404 ve 401 hata sayfaları mevcuttur.

-------------------------------------------------------------------------------------------------------------------

### Yazar Panelinde;

- Kullanıcı işlemleri ile ad, şifre, profil resmi (dosya yükleme) gibi bilgileri güncelleyebilme imkanı sunulmaktadır.

- Site sahibine (admin) ve diğer yazarlara (kullanıcılar) e-posta gönderebilme ve site sahibinden gelen mesajları görüntüleyebilme özellikleri bulunmaktadır.
  
- Yazar Panelindeki Dashboard üzerinde tüm istatistik bilgileri, hava durumu göstergesi gibi bilgilere erişemk mümkündür.
  
- Yazar panelinde duyuru bildirim iconu bulunmaktadır

-------------------------------------------------------------------------------------------------------------------

### Projemde Kulladığım Katmanlar:

📌 Business Layer 

📌 Presentation(WebUI) Layer 

📌 Entity Layer 

📌 Data Access Layer

📌 API

-------------------------------------------------------------------------------------------------------------------

### Proje kapsamında kullanılan paketler:

📌 Microsoft.Entity.FrameworkCore (8.0.5)

📌 Microsoft.Entity.FrameworkCore.Desing (8.0.5)

📌 Microsoft.Entity.FrameworkCore.SqlServer (8.0.5)

📌 Microsoft.Entity.FrameworkCore.Tools (8.0.5)

📌 Microsoft.AspNetCore.Identity(2.2.0)

📌 Microsoft.AspNetCore.Identity.EntityFrameworkCore(8.0.4)

📌FluentValidation.AspNetCore(11.3.0)

-------------------------------------------------------------------------------------------------------------------

### Proje kapsamında kullanılan teknolojiler:

📌 ASP.NET Core 8.0

📌 Entity Framework Core

📌 Asp.Net Core Identity & Rolleme

📌 N Tier Architecture

📌 Ajax

📌 Restful API

📌 Fluent Validation

📌 Swagger & Postman (API Kısmında)

📌 Code First

📌 Linq Sorguları

📌 Repository Design Pattern

📌 Authentication & Authorization

📌 Code First / MSSQL

-------------------------------------------------------------------------------------------------------------------

## Proje Görselleri

### Portfolio Sitesi

![portfolioFeature](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/618b1788-e5d8-4705-b655-c9f36a8f018a)

![portfolioHizmetler](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/1116c751-7968-4220-9e97-a53d34d3cf40)

![potfolioProjeler](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/d9751279-93ae-4f1a-a3df-f69062889f87)

![potfolioYetenekler](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/b96b9d84-b41c-4a57-b3e5-7d92a2af1375)

![PortfolioReferanslar](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/575e103f-d3de-4b6b-b5c4-9d393afcf8a7)

![portfolioDeneyimler](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/f4139f99-f82b-4c45-87bd-2bd72e0a41ce)

![potfolioİletişim](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/3737c876-4cec-4d65-b2fe-9a209e3dd0ff)


-------------------------------------------------------------------------------------------------------------------


### Yazar Paneli

Yazar Giriş
![yazarLogin](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/06957704-84f2-48e0-a3f4-964d0aa37f1a)


Yazar/Kullanıcı Kayıt
![YazarRegister](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/329d26f8-76d9-4a92-adb9-89926434fe5e)


Yazar Dashboard
![yazarDashboard](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/d10c0df0-cf24-4606-82f9-3169c48c1b1e)


Yazar Üst Menü Duyuru Bildirim Kutusu
![yazarDuyuruBildirimKutusu](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/bd90beb9-5966-4d4d-b4b3-fb19fae686b0)


Yazar Duyurular Sayfası
![yazarDuyuru](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/76f4da4f-2225-4691-a266-ea17964f6135)


Yazar Profil Güncelleme
![yazarprofilgüncelleme](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/09126194-99fa-4ec7-9123-bd0bfd13f7bd)


Yazar Güncellenmiş Profil
![YazarGüncellenmişProfilveResim](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/7c47ef53-26ec-49a4-9986-891eb4c74451)



Yazar Gelen Mesajlar
![yazarGelenMesajlar](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/fc8654d2-3e4d-4393-a25e-ce27f77bbf2d)

Yazar Gelen Mesaj Detayı
![YazarGelenMesajlarMesajDetayı](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/ccfd0383-14fa-470a-8a8a-2203f32626d5)





Yazar Giden Mesajlar
![yazarGidenmesajlar](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/d40c0fef-8fae-4e89-864c-00b89192b452)


Yazar Giden Mesaj Detayı
![GidenMesajDetay](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/baccfad3-10c6-4722-b998-b438e08e61dc)



Yazar Mesaj Gönderme
![yazarMesajGönderme](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/aeb385a4-ae21-4f52-a2ce-aafd6bc84ce3)


Yazar Gönderilmiş Mesaj
![yazarMesajGönderildi](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/66873bf5-8d9e-4a76-87da-eaa76806fbb6)


Yazar - Admin Paneli (Burada Rolleme Devreye girmektedir ve sadece Rolü Admin Olan kullanıcılar Admin Sayfasına Git sekmesini görebilir. Bu yazar Admindir aynı zamanda)
![yazarAdminPaneli](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/67b8dd3f-4ebf-44ae-8fff-cc5813694650)



-------------------------------------------------------------------------------------------------------------------


### Admin Paneli

Admin Dashboard - Burada Admin 
![AdminPaneliDashboard](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/9c2836f1-e548-401c-9dc5-1519868b321e)


Admin Üst Menü Mesaj Listesi
![adminÜstMenüMesajListesi](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/83863d9e-1970-49f8-be89-3cf23c3b360d)


Admin Üst Menü Duyuru Bildirim Kutusu
![adminÜstMenüDuyuruBildirim](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/94cf175a-e800-439f-8836-0b30f370dd94)


Admin Üst Menü Ayarlar ve Çıkış Yap Sekmesi
![adminüstMenüÇıkışYap](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/6b51a0c2-4b3c-4d70-b039-9b86da30a504)


Admin Üst Menü Proje, Hesap Ve Deneyim Ekleme Sekmeleri
![adminÜstMenüProjeHesapDeneyimEklemePaneli](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/e431309a-5a39-4f64-b6ff-893924e8ba39)


Admin SideBar (Yan Menü) Kapalı Hali
![adminSideBarKapalıHali](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/7d6e731e-51a8-46ab-aba8-2e9a7f9976bb)


Admin Yetenekler Sayfası (Koşullu Renklendirme kullanılmıştır)
![adminYetenekler](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/0a5fbd15-a642-4504-8b1e-5de89e866ef5)


Admin Yetenek Güncelleme Sayfası
![adminYetenekGüncelleme](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/50a1b14f-dc18-457d-b84f-0a2d3a5a62c2)


Admin Deneyim Sayfası
![adminDeneyim](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/cd02ee7d-acd4-4620-bc1f-4c52b61740db)


Admin Hizmetler Sayfası
![adminHizmetler](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/f829a3c8-9a20-4568-a188-f53fc5676341)


Admin Projelerim Sayfası
![adminProjelerim](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/74fbddd9-326c-42d3-bf9b-7a109f785134)

Admin Proje Ekleme
![AdminProjeEkleme](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/2dbc988e-22ae-4ccc-a759-4920578bf559)


Admin Referanslar Sayfası
![adminReferans](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/b1502922-202c-4957-8ea3-a878f2caa1bc)


Admin Hakkımda Sayfası
![adminHakkımda](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/0d9826e8-1a46-4d11-9566-701e275479a4)


Admin Öne Çıkanlar Sayfası
![AdminÖneÇıkan](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/bf55ab4a-2aa8-433d-a121-2eab0abc0a8b)


Admin Sosyal Medya
![adminSosyalMedya](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/5740d622-160a-477e-a3b3-50de3f15ffa1)

Admin 401 Hata Sayfası
![admin401hata](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/6baf87be-5455-4328-bd4d-cf5bec9f53e8)


Admin 404 Hata Sayfası
![adminhatasayfası404](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/b6b21171-a0ae-487d-b6e9-374030ec60f5)


Admin İletişim Sayfası (Siteden gönderilen mesajlar yer almaktadır. Mesajı okuduktan sonra okundu yapabilmektedir.)
![adminSitedenGelenMesajlarİletişim](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/63f42e82-9405-45ed-ad1a-61c042190a4b)


Admin İletişim Detay (Gelen Mesajı Açmak İsterse)
![adminİletişimDetay](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/9d623950-2fd7-49ec-9c01-24ff46869fcf)


Admin Alt İletişim (Sitede mesaj gönderme kutusunun sağında yer alan iletişim bilgileri bölümü)
![adminAltİletişim](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/41b2a911-aff6-40fd-aa0f-0764a7c985f5)


Admin yazara Mesaj Gönderme
![AdminMesajGönderme](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/46a9158c-6168-4dc8-ad49-197f249bf276)


Admin Yazara Mesaj Gönderilmiş Hali
![AdminGönderilenMesaj](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/6edfca43-c87e-4b21-a068-18e6a18ee4ae)


Admin Gönderilen Mesaj Detay Sayfası
![AdminGidenMesajlarDetay](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/984c4ca8-fe45-4442-961a-d93166c0d397)


Admin Gelen Mesaj Sayfası
![AdminGelenMesajlar](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/093e4048-2b93-48ec-97a5-b3fe3521ebc3)


Admin Gelen Mesajı Açınca 
![adminGelenMesajDetayı](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/1909692c-4c7b-475a-b831-b73445820321)



-------------------------------------------------------------------------------------------------------------------


### Admin Paneli - AJAX

Admin Ajax Deneyim Sayfası
![adminDeneyimAjax](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/566661a4-381e-44be-b626-4f56322c7913)


Ajax ile verileri getir
![AdminAjaxVeriGetir](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/28bb97bc-821f-4c2f-affb-d6c7d0d797ec)


Ajax ile veri ekleme
![adminAjaxVeriEkleme](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/6ece7533-d22d-42b4-9026-e5922237e52d)


Ajax ile eklenen veri getirildi
![adminAjaxVeriEklendi](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/f0cc46cd-906f-4eae-9aa6-f67151cca4fb)


Ajax ile ID 'ye bağlı veri getirme
![AdminAjaxGetById](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/c5964cf9-185b-4d52-a896-9f911fd475c9)


Ajax ile güncelleme
![adminAjaxGüncelleme](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/e10b1b3f-bd76-473b-9611-343e154459fb)


Ajax ile veri güncellendi
![adminAjaxGüncellendi](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/2c49d9aa-c0c2-4f55-80ab-d908e288a0a7)


Ajax ile Veri Silme
![adminAjaxSilindi](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/8384c772-81ec-496b-abe5-8e36254ea2b3)

-------------------------------------------------------------------------------------------------------------------


### Admin Paneli - Rolleme İşlemleri

Atanan Roller (Admin rolü id'si 1'dir, 2 olanlar ise yazar rolü idsidir. yani admin kullanıcısına 1(admin) rolü atandı diğer tüm kullanıcılara yazar rolünü atadık)
![AdminRolleme](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/451abfaa-3fb4-4ed3-85ca-1c926bdf5cc0)


Rolü Admin OLan yazar panelinde Admin Paneline gitme sekmesine bu kısım sayesinde ulasır
![rolüAdminOlanAdminPanelineErişir](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/d0b13c98-4c08-4743-b1cc-635b42f3e2c2)


Sadece Rolü Admin Olanlar Admin Dashboard sayfasına erişebilir yani rolü yazar olan kullanıcı url 'le Dashboard/Index yazsa bile buraya erişemez.
![adminRoleSadeceRolüAdminOlanlarErişebilir](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/02aec7f1-e99a-417b-b9b6-13ddfdc03b1f)



-------------------------------------------------------------------------------------------------------------------


### API - Swagger


Burada Projemde yapmış olduğum api katmanındaki metotlar gözükmektedir.
![swagger](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/a9317284-b500-4d95-857a-d194afed8f18)


HttpGet ile verileri getirdim
![apiGet](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/66c78956-ad48-4fa4-96d2-190e2c137db0)


[HttpGet("{id}")] ile id'ye bağlı veri getirdim
![apiGetById](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/f19c8b7d-0227-4c52-8a5c-fb998d051e05)


[HttpPost] ile yeni veri ekledim
![apiPost](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/0d2b65b3-9256-409a-b06c-6a469ba076ce)


[HttpPut] ile veri güncelledim
![apiPut](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/5e45c8d3-89e1-4653-a320-855068bb132e)


[HttpDelete] ile veri sildim
![apiDelete](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/1937091f-ac35-440d-a44b-edb7f660d5f4)

API CRUD işlemlerimin son hali
![apisonHali](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/b85fedc9-9613-4f25-b8ea-70ed20b69071)


-------------------------------------------------------------------------------------------------------------------


### API - Postman

GET metodu ile verileri getirdim
![postmanGet](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/dff9ad52-abbe-4ecb-b3e5-c15f45675247)

Get metodu ile id belirterek veri getirdim
![postmanGetById](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/90315f57-3bec-4272-a0d5-989345b5e959)

Post Metodu ile yeni veri girişi yaptım
![postmanPost](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/904b94e2-9e72-4d2d-adeb-3431031a2b79)


Post Metodu ile yeni veri girişi yaptıktan sonra yeni verileri getirdim
![postmanPostToGet](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/b82f2ae7-a0e9-4099-a5d2-d5901019d34f)


Put Metodu ile Veri güncelledim
![postmanPut](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/d3b87975-281f-485f-8c88-d0a350472f4a)


Güncelledikten sonra
![postmanPutToGet](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/540574e8-e73d-40f2-a3ff-c6a6ba348234)


DELETE metodu ile veri sildim
![postmanDelete](https://github.com/esincaglakiral/NetCore_PortfolioProject/assets/68962573/de1a41a7-24a4-482c-8257-658d5a418a4f)


-------------------------------------------------------------------------------------------------------------------

Buraya kadar projemi incelediğiniz için teşekkür ederim. Kodlarla alakalı detaylara yukarıdan ulaşabilirsiniz...
