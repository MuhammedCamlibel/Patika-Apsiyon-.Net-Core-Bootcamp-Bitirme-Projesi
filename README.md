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
***

### Kurulum 

* Gerekli olan Teknolojiler
    * MS SQL
    * MongoDb
    * .Net Core 5.0

* Sistemin Kurulması 
    * MS SQL : 
        * BitirmeProjesi.WebUI katmanı Set as Startup Project denerek seçilir.
        * BitirmeProjesi.Data katmanı seçilerek Package Manager Console açılır.
        * Ardında sırayla aşağıdaki kod satırları yazılarak Migration oluşturulur ve veritabanına aktarılır.
         
         ```bash
          Add-Migration -Context ProjeDbContext
          Update-Database -Context ProjeDbContext
         ```     
    
    * MongoDb :
        * MongoDb local olarak kurduktan sonra ;
        * Banking adında bir database oluşturulur.
        * Oluşturulan database'e CreditCard adında collection eklenir.
           * Ekledimiz collection'a serviste kullanılacak fake kredi kartı eklenir   
           * Kredi kartı bilgileri arasında (Owner,CardNumber,ValidMonth,ValidYear,Cvv,Balance) özellikleri bulunmalıdır.
           * Örnek olarak aşağıdaki gibi bir veri girilebilir : 
              * Owner : Muhammed , CardNumber : 123123 , ValidMonth : Mart , ValidYear : 2022 , Cvv : 123 , Balance : 10000
    
    * Son Olarak BitirmeProjesi nin Properties kısmına gelerek Multiple startup projects seçilerek önce servis sonra WebUI Katmanı çalışacak seçilde ayarlandıktan sonra proje kullanıma hazır hale gelir 

    *** 

    ### Admin Kullanıcı ile Giriş Yapılması 

    * Sistem ilk açıldığında oluşan ve sistemde sürekli var olan admin kullanıcısının bilgilerini BitirmeProjesi.WebUI katmanında appsettings.json dosyasında tanımladım ordaki bilgilere bakarak ; 
    
    * Username alanına:  Admin Password alanına:  Muhammed_123 diyerek Admin kullanıcı ile giriş yapabilirsiniz.


