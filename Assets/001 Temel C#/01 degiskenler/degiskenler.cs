using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class degiskenler : MonoBehaviour
{
    int a = 3; 

    //private şeklinde ayarlarsak diğer classlardan ulaşamayız. Global variable.
    //başına bir şey yazılmadığı zaman private kabul edilir.

    //Değişken isimleri benzersiz olmalı.
    //Değişkenler büyük küçük harfe duyarlıdır.
    //Değişkenler sayı ile başlayamaz.
    //Değişkenler belirtilirken "camelCase" yöntemi kullanılır. Örn : aracSayisi, ögrenciAdi, ayakkabiNumarasi...
    //Değişkeni deklare ettikten sonra ";" kullanılır.

    int a1 = 3;
    int hp = 100;
    string cumle = "falanfilan";
    bool dogruYanlis = false;
    float sayi2 = 20.5f;
    decimal sayi3 = 20.35m; //bu değişkenler hep ram'ın stack bölümünde ktutuluyor.
    bool aktifMi;   //ramda saklanan hiçbir değer null olamaz.    
    string araba = "Mercedes";
    string ad = "Mert";
    string soyad = "Çılgasıt";
    int yas = 24;



    //inspectorda script pasif olsa bile script çalışır.Yalnızca Awake çalışır. Start ile update çalışmaz.Hiyerarşide aktif olmak zorunda!

    //buraya global değişkenler yazılır.
    //buraya yazılan değişkenler alttaki tüm voidlerce görülür.
    //başında void varsa metotdur
    //class altındaki değişkenlere altındaki her metotdan ulaşabiliyoruz ama aksi geçerli değil.
    //metotların içerisine local değişkenler yazılır 

    private void Awake()       
    {
        //script dosyası inspectorda pasif olsa bile "Awake" çalışır.Start ile arasındaki en büyük fark budur. Start çalışmaz.
        //Unity İşlevsel Method

        //Debug.Log("Awake Çalıştı"); // console'a yazı yazdırma kodu.
                                  
        //Tek sefer çalışır.

    }

    private void Start()        //
    {
        //Unity İşlevsel Method
        Debug.Log("benim arabam Mercedes");
        Debug.LogError("benim arabam " + araba);//programerlar arasında iletişim amaçlı veya oyun ile oyun dev. arasında iletişimi sağlar. kırmızı ünlemle konsola yazdırır.(kritik kod hatarları)
        Debug.LogWarning(araba);//bu da sarı ünlem verir.sarı ünlemle konsola yazdırır.(sarı her türlü ui fizik işleri düzeltilmesi için kullanılır)
        Debug.Log("Start Çalıştı");
        Debug.Log(sayi2);
        Interpolition();

        //Start methodu awakeden sonra çalışır. Start metodunun çalışması için scriptin inspectorda aktif olması gerekir.
        //Tek sefer çalışır.
    }

    //private void Update()
    //{
    //    Debug.Log("Update Çalıştı");

    //    //her framede çalışır. Bilgisayarın hızına bağlı olarak çağrılma hızı değişir.

    //}

    //private void FixedUpdate()
    //{
    //    Debug.Log("Düzenli bir şekilde çalışıyor.");
    //    //genellikle oyun fizik bölümlerinde kullanılır. Her 0.02 saniyede bir çağrılır. Bu değer değiştirilebilir.
    //    //fizik olaylarında normal update kullanılması sağlıklı değildir. Nedeni ise belirli aralıklarla çalışmadığı için.
    //    //örn: topun havadan yere düşmesi

    //}


    //private void LateUpdate() 
        //void : değer döndürmeyen bir metot olduğunu belirtir.
        //en son çalışan update fonk.dur. update gibi çalışır. Örn. Loading ekranından hemen sonra çalışması gereken fonk.
        //tüm işlemler bittikten sonra çalışır. Genel olarak Camera , çevre yüklemesi(FixedUptade'de çalışır.) bittikten sonra çalışır.
   // {
   //    Debug.Log("en son çalışan update fonk.");
   // }

    private void Interpolition()       
    {
        Debug.Log($"benim arabam {araba}");     //tırnak içerisine yazdığımız  ifade içerisine scoplar aracılığıyla değerleri çekebiliriz.
        Debug.Log($"benim adım: {ad} soyadım: {soyad} yaşım:{yas} ");//bu yazım şeklinin adı interpolition.
        
    }

    //string sinif = "Öğrenci";    //local variable
    //update fonk. bilgisayarın performansıyla doğru orantılı güzel çalışır.
    //fixupdate fonk. herkeste eşit şekilde çağrılır çalışır.

    
    //Debug.
    //BREAKPOİNT KONULARINI ARAŞTIR. KULLANMAYI ÖĞREN!!!
    //DEBUG MODU KULLANMAYI TEKRARDAN ARAŞTIR.
}

