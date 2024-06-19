# Plak Dükkânı Yönetici Modülü

Bu proje, albüm plakları satan bir dükkân için yönetici(admin) modülünü içermektedir. Proje, Entity Framework teknolojisi ve Code First yaklaşımı kullanılarak geliştirilmiştir. Windows Forms üzerinde çalışan bu uygulama, yöneticilerin albüm ekleme, güncelleme ve silme işlemlerini gerçekleştirmesini sağlar. Ayrıca, yönetici giriş ve yeni yönetici kayıt işlemleri de bu modül üzerinden yapılabilir.

## İçindekiler

- [Özellikler](#özellikler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Veritabanı Yapısı](#veritabanı-yapısı)
- [Ekran Görüntüleri](#ekran-görüntüleri)


## Özellikler

- **Yönetici Giriş Bölümü**: Yöneticilerin kullanıcı adı ve şifresi ile sisteme giriş yapabilmesi.
- **Yönetici Kayıt Bölümü**: Yeni yöneticilerin sisteme kayıt olabilmesi. Kullanıcı adı, şifre ve şifre tekrarı gereklidir.
  - Şifre kriterleri:
    - En az 8 karakter uzunluğunda olmalıdır.
    - En az 2 büyük harf içermelidir.
    - En az 3 küçük harf içermelidir.
    - ! (ünlem), : (iki nokta üst üste), + (artı), * (yıldız) karakterlerinden en az 2 tanesini içermelidir.
- **Albüm Yönetimi**: Albüm ekleme, güncelleme ve silme işlemleri.
- **Albüm Listeleri**:
  - Bütün albümler
  - Satışı durmuş albümler
  - Satışı devam eden albümler
  - Sisteme en son eklenen 10 albüm
  - İndirimdeki albümler (İndirim oranına göre sıralanmış)

## Kurulum

Bu projeyi kendi bilgisayarınıza kurmak için aşağıdaki adımları izleyin:

1. Bu depoyu klonlayın:
    ```bash
    git clone https://github.com/mihrapgozcu/Mihrap_Plak
    ```
2. Proje klasörüne gidin:
    ```bash
    cd plak-dukkani-yonetici-modulu
    ```
3. Projeyi Visual Studio ile açın ve gerekli bağımlılıkların yüklendiğinden emin olun.
4. `NuGet Package Manager` kullanarak Entity Framework paketlerini yükleyin.
5. Veritabanını oluşturmak ve gerekli tabloları eklemek için `Code First Migrations` kullanın.
6. Projeyi derleyin ve çalıştırın.

## Kullanım

Projeyi çalıştırdıktan sonra, kullanıcı arayüzü üzerinden aşağıdaki işlemleri gerçekleştirebilirsiniz:

- **Yönetici Girişi**: Kullanıcı adı ve şifre ile giriş yapın. Bilgiler yanlış ise hata mesajı alınacaktır.
- **Yeni Yönetici Kaydı**: Kullanıcı adı, şifre ve şifre tekrarı bilgilerini girerek yeni bir yönetici kaydı oluşturun. Şifre kriterlerine dikkat edin.
- **Albüm Yönetimi**:
  - **Albüm Ekleme**: Yeni bir albüm ekleyin.
  - **Albüm Güncelleme**: Mevcut bir albümü güncelleyin.
  - **Albüm Silme**: Bir albümü silin.
- **Albüm Listeleri**: Farklı kriterlere göre albüm listelerini görüntüleyin.

## Veritabanı Yapısı

### Tablo: Yöneticiler (Admins)
- Id (int, PK)
- KullaniciAdi (string)
- Sifre (string, hashed)

### Tablo: Albümler (Albums)
- Id (int, PK)
- Ad (string)
- SanatciGrup (string)
- CikisTarihi (datetime)
- Fiyat (decimal)
- IndirimOrani (float)
- SatisDevam (bool)

## Ekran Görüntüleri

### Yönetici Giriş Sayfası
![Yönetici Giriş Sayfası](https://github.com/mihrapgozcu/Mihrap_Plak/blob/master/giris%20ekrani.png)

### Yönetici Kayıt Sayfası
![Yönetici Kayıt Sayfası](https://github.com/mihrapgozcu/Mihrap_Plak/blob/master/kay%C4%B1t%20ekran%C4%B1.png)

### Albüm Yönetimi Sayfası
![Albüm Yönetimi Sayfası](https://github.com/mihrapgozcu/Mihrap_Plak/blob/master/analiz%20ekran%C4%B1.png)

### Albüm Listeleri Sayfası
![Albüm Listeleri Sayfası](https://github.com/mihrapgozcu/Mihrap_Plak/blob/master/sorgular.png)


