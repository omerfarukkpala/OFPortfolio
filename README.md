# Ömer Faruk Pala Portfolio         
https://palaomerfaruk.com.tr/                    
                                  
                         
               
https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/b57f85f0-c802-4081-bbbb-e6f6cb8d62ed
   
  

## Proje Hakkında: 
ASP.Net Core kullanarak Entity Framework Core ve N Tier Architecture mimarisi ile kodlanmıştır. Codefirst yaklaşımı ile SQL Server veritabanını destekleyen bir Portfolio sitesi projesidir. Default, Yazar ve Admin panellerine sahiptir.

#### Proje Detay 
Projenin 3 temel paneli var.
Bu projede eğitim hayatım, deneyimlerim, referanslarınım, projelerim gibi bilgiler bulunuyor.Yazar panelinde  sistemiminize kaydolup bu sistem üzerinden haberleşecek kişiler için bir panel oluşturuldu. Bu panelde kişiler mesajlaşma, duyurular, profil bilgilerini düzenleme, şifre değiştirme gibi işlemlere erişim sağlayabilirler. Admin paneli ise projenin esas kısmını oluşturmakta. Admin panelinde kullanılan özellikleri   videoda net bir şekilde görebilirsiniz.



 
## Proje de Kullanılan Teknolojiler:
* Asp.Net Core kullanarak web uygulamalarının geliştirilmesi
* Entity Framework Core ile veritabanı işlemleri
* Repository Design Pattern kullanımı
* N Katmanlı Mimarilerin uygulanması
* Fluent Validation ile giriş doğrulama ve veri doğrulama
* Restful API tasarımı ve geliştirilmesi
* Postman ile Api isteklerini yapma,
* Area kullanımı ve route işlemleri,
* Identity ve Rolleme,
* Uygulamanın dağıtımı (Deploy) süreci
* Github yönetimi ve versiyon kontrolü
* Grafiklerin oluşturulması ve görsel sunum
* Ajax kullanımı ve sayfa yenilemesi gerektirmeyen etkileşimler
* Kimlik doğrulama ve yetkilendirme (Identity) sisteminin entegrasyonu
* Rol tabanlı yetkilendirme işlemleri
* Dosyadan resim yükleme işlemi,
* Admin paneli ve yazar paneli için ayrı roller atama,
* silme işlemini alert ile kullanma,
* ViewComponent ve Partial kullanımı vs..


## Proje Kurulumu
![image](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/9f3f2ad4-fc4b-4b84-9448-b8fa1a6cdd4f)

```
Local Context.cs
 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 {
     optionsBuilder.UseSqlServer("server=servername;database=databasename;integrated security=true");
 }

Production Context.cs

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
optionsBuilder.UseSqlServer("server=ipadress\\MSSQLSERVER2019;database=databasename;user=username;password=@password?");
}
```

## Projeyi Calistirmak Icin:
```
Entity Framework Code First
Enable-Migrations: Enables the migration in your project by creating a Configuration class.
Add-Migration: Creates a new migration class as per specified name with the Up() and Down() methods.
Update-Database: Executes the last migration file created by the Add-Migration command and applies changes to the database schema.

https://www.entityframeworktutorial.net/code-first/code-based-migration-in-code-first.aspx

```

## Projeyi Browser'da Acmak Icin:
```
Index  = https://localhost:44335/
Writer = https://localhost:44335/Writer/Login/Index
Admin  = https://localhost:44335/Dashboard/Index
```

###  Veritabanı 
![image](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/1a1589d1-bd6d-4ef7-aa91-f83c6c19bd45)

![image](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/020e572b-f798-4fca-a490-648c9a45d6e0)

## Proje Görselleri 
![image](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/f4d85397-52a8-4160-a209-4e3a5ae48931)
## Anasayfa
![image](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/17b7bff5-a7bb-459f-a835-ba62e888df7d)
## Hakkımda
![image](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/92241cbc-2c8e-408e-aeeb-90665c08b695)
## Hizmetlerim
![image](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/5ed6bc31-d280-46cd-bcf3-0456431b851c)
## Yeteneklerim
![image](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/46e46a08-b918-4650-9d9d-5ec14c6b5d7b)
## Projelerim
![image](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/af533456-5f0f-4dfe-990f-9bda22afac69)
## Deneyimlerim Ve Eğitimlerim
![image](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/8dee32b7-922a-4c03-ab06-22cecc4bc240)
## Referanslarım
![image](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/4a08ece2-0cc8-4dfe-891b-084c1065fcb0)
## İletişim 
![image](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/6126f4ca-8b32-4eec-bd76-293db01696f2)

## Anasayfa Komple
![screencapture-palaomerfaruk-tr-2024-05-05-23_00_10](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/6d96326e-d3b5-4478-9879-75b7e14e2fd2)

## Yazar Kayıt Ol
![screencapture-palaomerfaruk-tr-Writer-Register-Index-2024-05-05-23_12_56](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/da418442-e296-436a-b347-8ae8b0e7c71b)

## Yazar Giriş
![screencapture-palaomerfaruk-tr-Writer-Login-Index-2024-05-05-23_11_47](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/9aeb42a0-4008-4118-9d67-f48159d7f6e4)

## Yazar Dashboard
![screencapture-palaomerfaruk-tr-Writer-Register-Index-2024-05-05-23_12_56](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/90cabdbf-5117-4d64-91c8-06f6764eb409)
## Yeni Mesaj
![screencapture-palaomerfaruk-tr-Writer-Message-NewMessage-2024-05-05-23_23_11](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/f11802d3-da56-461f-9ae1-0ab02cf38c2e)

## Gelen Mesaj
![screencapture-palaomerfaruk-tr-Writer-Message-Inbox-2024-05-05-23_24_03](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/e17784cf-152c-4824-b0c1-f57e35890ca6)

## Gelen Mesaj Detay
![screencapture-palaomerfaruk-tr-Writer-Message-InboxMessageDetails-1-2024-05-05-23_24_45](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/4b752b99-2878-4242-b489-ff0141c25cd9)

## Duyurular
![screencapture-palaomerfaruk-tr-Writer-Announcement-Index-2024-05-05-23_25_28](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/09062be5-bf51-4830-9bff-78b0af7da79a)

## Profil
![screencapture-palaomerfaruk-tr-Writer-Profile-Index-2024-05-05-23_29_33](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/b1986bee-7941-4490-8fb8-227a0cd942c4)

## Ayarlar 
![screencapture-palaomerfaruk-tr-Writer-Profile-Setting-2024-05-05-23_30_26](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/d08db3da-dba1-41b9-bf34-68002ed62816)

## Çıkış Yap
![image](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/06577d88-92c6-4a24-ad45-c6756467efe1)

## Admin Paneli 
### Dashboard
![screencapture-palaomerfaruk-tr-Dashboard-Index-2024-05-05-23_35_59](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/9421adc5-9045-47e4-9ae4-296b54712490)

## Öne Çıkan 
![screencapture-palaomerfaruk-tr-Feature-Index-2024-05-05-23_40_01](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/315a20c2-203f-40f7-b4f8-f1f0ce6a0ab7)

## Hakkımda 
![screencapture-palaomerfaruk-tr-About-Index-2024-05-05-23_41_21](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/3883dd0a-5eda-45e2-a9e1-dc499f200bc8)

## Hizmetlerim 
![screencapture-palaomerfaruk-tr-Service-Index-2024-05-05-23_42_46](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/d12ccbf8-776d-4980-8057-b30464575207)

## Yeteneklerim
![screencapture-palaomerfaruk-tr-Skill-Index-2024-05-05-23_44_45](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/17828ad4-3089-4eaf-9b6c-b5f10cff3eff)

## Deneyim Listesi
![screencapture-palaomerfaruk-tr-Experience-Index-2024-05-05-23_45_51](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/5572bb18-98f8-4480-9628-b15eebb53a45)

## Deneyimlerim Ajax 
![screencapture-palaomerfaruk-tr-ExperienceAjax-Index-2024-05-05-23_48_11](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/cadd67ce-8be5-491d-bdea-902eaa91fe5d)

## Referanslarım 
![screencapture-palaomerfaruk-tr-Testimonial-Index-2024-05-05-23_49_32](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/0df60a8d-c25e-405a-ae5a-965f229aa217)

## İletişim Bilgilerim
![screencapture-palaomerfaruk-tr-ContactInfo-Index-2024-05-05-23_50_21](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/93bfea8a-39c8-43f3-882a-d4ef09886208)

## Sosyal Medaya Bilgileri
![screencapture-palaomerfaruk-tr-SocialMedia-Index-2024-05-05-23_52_45](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/c251c283-9b6e-4ce8-b889-6d08d175fad4)

## Duyuru İşlemleri
![screencapture-palaomerfaruk-tr-Announcement-Index-2024-05-05-23_53_33](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/e89e657a-2988-4456-ad1f-25eb40c2e299)

## İletişim
![screencapture-palaomerfaruk-tr-Contact-ContactDetail-1-2024-05-05-23_55_31](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/d9662d1e-aa29-4c0c-95e3-d4b70cce9773)

## Mesajlar 
![screencapture-palaomerfaruk-tr-AdminMessage-AdminMessageDetailS-3-2024-05-05-23_58_38](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/55d2a4f7-8aff-460a-8167-60e3e11c3326)

## Mesajlar Giden Kutusu 
![screencapture-palaomerfaruk-tr-AdminMessage-Sendbox-2024-05-06-00_02_00](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/c199800e-0356-4071-9ab9-0d92a466802c)


## Roller 
![screencapture-palaomerfaruk-tr-Role-Index-2024-05-05-23_59_42](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/0c9172e0-8c8b-4332-a71a-40349fe99161)

## Aradığınız Sayfa Bulunamadı
![screencapture-palaomerfaruk-tr-Writer-Login-Index6-2024-05-06-00_02_32](https://github.com/omerfarukkpala/OFPortfolio/assets/101570820/23255b7a-0d44-4f17-861f-518f0d9040a8)










