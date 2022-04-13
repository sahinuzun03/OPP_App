# OOP_Applications
Bu repoda temel OOP kurallarını öğrenmenize yardımcı olur.
### Neden OOP'ye ihtiyaç duyarız?
Yazılımın tasarımını veri ve nesneler üzerinden organize eden bir modeldir. C# ile nesne düzeyinde kod yazılmasını sağlar.
### Class Concept
İhtiyaç duyulan nesnelerin özelliklerinin ve davranışlarının tutulduğu kısımdır. Belirlenen davranışlar metotlarla sınıflara aktarılır. Sınıfta belirtilen değişkenler sınıfta kullanılacak bilgileri tutarken; Yöntemler, sınıfın gerçekleştireceği görevleri tanımlar. Bir sınıfta üretilen bir nesne tüm programda kullanılabilir ve nesne üzerinde yapılacak bir değişiklik için nesnenin bulunduğu sınıfın güncellenmesi yeterlidir.
### Inheritance (Kalıtım)
```
class UlasimAraci 
{
  //Common vehicle properties
}

class Araba : UlasimAraci
{
  //Ulasim Araci properties
  //Araba properties and methods
}
```
Bir sınıfın özelliklerinin bir alt sınıfta da kullanılabilmesi durumudur.
### Abstraction (Soyutlama)
Bir sınıfın davranış ve özelliklerinin tanımıdır.
* Soyut sınıflar genellikle kalıtım uygulanırken kullanılır.
* Nesneye aktarılamaz ve yeni kelime ile kullanılamazlar.
* Soyut sınıflardan türetilen tüm sınıf yöntemlerinin kullanılması zorunludur.
* Bir sınıf yalnızca soyut bir sınıftan miras alabilir.
* Statik olarak tanımlanamazlar.

### Polymorphism (Çok Biçimlilik)
Bir üst sınıftan özellikleri miras alan bir alt sınıf, üst sınıftan farklı davranabilir. Üst sınıf nesnelerle ortak özelliklere sahip olmalarına rağmen farklı özellikleri tanımlayabilme yeteneğine polimorfizm denir.

### Encapsulation (Kapsüllee)
Bir sınıfın özellikleri ve davranışları bir sınıfta soyutlanır ve saklanırken, o sınıfın hangi özelliklerinin enkapsülasyon ile açığa çıkıp çıkmayacağını sınırlayabiliriz. Kapsülleme ile belirtilen özelliklerin sunulup sunulmayacağı kontrol edilir.

### Interface

Soyutlama için kullanılan bir yapıdır. Yazılı yöntem tanımlarını kendisinden türeyecek sınıflardan devralmak için kullanılır.
* Yeni anahtar kelime ile nesneler oluşturulamaz.
* Tüm arayüzler varsayılan olarak soyut ve genel olarak tanımlanmıştır.
* Çoklu kalıtım sağlar.
* İçerisinde sadece metotların imzaları yer almaktadır, dolgulu metot içeremezler.

> Arayüzdeki tüm yöntemler türetilmiş sınıf tarafından kullanılmalıdır.

### Method Overriding

Üst sınıfta tanımlanan bir yöntem, aynı imza ve parametreye sahip bir alt sınıfa miras alınır, ancak yöntem gövdesi yeniden yazılır.
* Geçersiz kılınan yöntemin döndürdüğü değer, üst sınıfta tanımlanan değerle aynı olmalıdır.
* Final anahtar sözcüğü ve statik yöntemler geçersiz kılınamaz.

