using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStaticClass : MonoBehaviour
{
    /*      Static Classlar sadece statik üyeler içerebilirler. (statik metot ve statik değişkenler.)
    
    
    Static olan bir class ya da yapı (fieldlar ve metotlar) tekildir(newlenmeden direkt olarak çağırabiliyoruz). 
    Yani bir kere oluşturulurlar ve program kapatılıncaya kadar ömürlerini devam ettirirler.
    Bizler genelde static classlardan kaçınırız. Bunun nedeni : bir static class olduğunda her şey 
    static olmak zorundadır.

    Mutlaka üyelerin başına static keywordu eklenmelidir.
    
    Statik  classlar başka bir sınıftan inheritance alamazlar.
    Bu classlardan staticte olsa başka classlar üretilemez 
    Newlenemez.

    static classlar belirlenirken static yapıdaki scriptler "s" veya "S" harfiyle ayrıştırılırlar örn: UrunlerS.cs

    doğrudan classAdi. ile çağrılabilir.



    */

    void Start()
    {
        Urunler _urunler1 = new Urunler()     /* {ID=1,ItemAdi="item1,ItemFiyati=445m}; diye de yazabiliriz           */
        {      
            ID = 1,
            ItemAdi = "item1",
            ItemFiyati = 445m,
        };

        Urunler _urunler2 = new Urunler()     /* {ID=1,ItemAdi="item1,ItemFiyati=445m}; diye de yazabiliriz           */
        {
            ID = 2,
            ItemAdi = "item2",
            ItemFiyati = 446m,
        };

        Urunler _urunler3 = new Urunler()     /* {ID=1,ItemAdi="item1,ItemFiyati=445m}; diye de yazabiliriz           */
        {
            ID = 3,
            ItemAdi = "item3",
            ItemFiyati = 447m,
        };




        StaticUrunler.ID = 1;
        StaticUrunler.ItemAdi="Gümüş Kılıç";
        StaticUrunler.ItemFiyati = 1000000m;

        StaticUrunler.ID = 2;           //yeni veri eski verinin üzeirne yazıldığı için gümüş kılıç gg oldu
        StaticUrunler.ItemAdi = "KDP";
        StaticUrunler.ItemFiyati = 1000000m;

        StaticUrunler.ID = 3;
        StaticUrunler.ItemAdi = "Dolunay";      //yeni veri eski verinin üzeirne yazıldığı için kdp gg oldu
        StaticUrunler.ItemFiyati = 1000000m;





        //List<object> urunList = new List<object>() { _urunler1, _urunler2, _urunler3,StaticUrunler.EkranaYazdir(),StaticUrunler.EkranaYazdir(),StaticUrunler.EkranaYazdir() };//object içinde her şeyi tutabilir.

        //biz kdp dolunay gümüş kılıçın hepsini yazdırmasını beklerken sadece dolunay yazıldı.    
        //static urunler id 3 ü 3 kere yazdırmış olur çünkü statikte son tutulan değer kalır.

        //foreach (var item in urunList)
        //{
        //    Debug.Log(item);        //tostringi ezerek yazdırma işlemi yaptık.
        //}

        List<string> urunList1 = new List<string>() { _urunler1.ToString(), _urunler2.ToString(), _urunler3.ToString(), StaticUrunler.EkranaYazdir() };
        foreach (var item in urunList1)
        {
            Debug.Log(item);        //tostringi ezerek yazdırma işlemi yaptık.
        }
        //StaticUrunler.Equals(true, false); hepsi özünde obje olduğu için equals gibi tanımlı fonksiyonları kullanabiliyoruz.
    }    
}
