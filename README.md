# Patika Apsiyon .Net Core Bootcamp Bitirme Projesi
### Kullanılan Teknolojiler
* Asp .Net Core MVC
* Asp .Net Core Web Api
* Entity Framework Core
* Identity framework
* MS SQL
* MongoDb
* Bootstrap

***

### Kullanılan Design Pattern
* Repository Pattern  
***

### Kullanılan .Net Core SDK Versiyonu 
* .Net Core 5.0
***

### Sistemdeki Kullanıcılar 

#### Admin/Yönetici : 
* Daire bilgilerini girebilir.
* İkamet eden kullanıcı bilgilerini girer.
* Daire başına ödenmesi gereken aidat ve fatura bilgilerini girer. 
* Gelen ödeme bilgilerini görür.
* Gelen mesajları görür.
* Aylık olarak borç-alacak listesini görür.
* Kişileri listeler, düzenler, siler.
* Daire/konut bilgilerini listeler, düzenler siler.
#### Kullanıcı : 
* Kendisine atanan fatura ve aidat bilgilerini görür.
* Kredi kartı ile ödeme yapabilir.
* Yöneticiye mesaj gönderebilir.
***

### Sistemin Kullanılması 

* Admin/Yönetici : Veritabanında sabit olarak oluşturulmuş Admin kullanıcı ile giriş yapar. Daire ve kullanıcı oluşturduktan sonra 
kullanıcıyı daireye atar.Son olarak dairenin fatura bilgilerini tanımlar. 

* Kullanıcı : Admin kullanıcısının oluşturduğu kullanıcı adı ve otomatik oluşturulmuş şifre ile giriş yapar.Daireye atanmış faturaları faturalarım alanında görür ve istediği faturayı seçer.Ödeme işlemini yapabilmesi için serviste tanımladımız kredi kartı bilgilerini girer.Kredi kartı bilgileri doğru ve bakiyemiz yeterliyse kredi kartından fatura tutarı çekilir ve faturamız ödenir.Ödenen fatura bilgileri faturalar tablosundan silinir ve ödenmiş faturalar tablosunda yeni bir kayıt oluşturulur.

