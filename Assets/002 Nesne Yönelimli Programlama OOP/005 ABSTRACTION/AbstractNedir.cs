using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractNedir : MonoBehaviour
{

    #region abstract
    //     Abstract (soyutlama):
    // Soyut ve somut base classlar vardır.Örneğin:
    // Araba, bmw, mercedes, toyota ve citroen classları base classlardır.
    // Bu sınıflar "araba" sınıfından miras almışlardır ve somut bir base class oldukları için newlenebilirler.

    //Araba classı ise hepsinin ortak noktasıdır ve soyut olması gerekir. 
    //Oluşturulan base classlar içerisinde ortak bir nokta varsa o ortak 
    //alanlardan base class oluşturulur ve soyutlama işlemi yapılır.

    //public abstract class Araba (){}   //ile abstract eklenir 

    //Yukarıdaki metot şu anlama gelir: abstract eklenerek araba classı soyutlaştırıldı ve başka bir yerde örneği (instance) alınamaz! (newlenemez duruma getirildi)

    //Abstractın genel olarak tek bir görevi vardıdr : Diğer classlara miras vermek bu amaç dışında kullanılamaz.
    //Abstract yapılan classlar içerisinde bulunan metotlara miras alınmayan sınıflardan ulaşılamaz. (Virtual Dışında)

    // Peki neden abstract yaptık ?
    //Solid prensiblerinin ilk harfi "S" :Single Responsibility Principle (SRP)

    //ÖZET: Bir sınıf (nesne / class) yalnızca bir amaç uğruna değiştirilebilir , o da o sınıfa yüklenen sorumluluktur.
    //Yani bir sınıfın (metotlara kadar indirgenebilir) yapması gereken sadece bir iş olmalıdır. 


    //abstract metotların virtualden farkı : abstractların mecburi şekilde implemente edilmesi gerekir ve içinin doldurulması gerekir.


    #endregion

    //------------SOLİD KAVRAMLARINI ARAŞTIR!-------------------//

    #region sealed
    // Sealed (mühürleme): Mühürleme anlamına gelir ve bu base class hiçbir class'a miras veremez. 



    //Wild Tera 2 Unity yapım oyun içerisinde dll okuyucular var bunlarla birlikte içerisindeki modellere kadar aktarabiliyormuşuz.
    //shop titans 





    #endregion

}
