using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DelegateOrnek : MonoBehaviour
{
    ///                                         <DELEGATE>
    ///  
    ///        Program içerisinde 1 veya daha fazla metodu gösteren "referans" türünden bir nesnedir.
    /// 
    ///        Programlarımızda temsilciler(delegate) kullanmak istediğimizde öncelikle bu temsilcinin tanımını yapmalıyız.     
    /// 
    ///        Delegate tanımları metot tanımları gibidir.
    /// 
    ///        Tek fark "delegate" anahtar sözcüğünü kullanırız.
    /// 
    ///                                         <DELEGATE>

    public delegate void DelegateOrnek1();      // bu metotumuz geriye değer döndürmeyen ve parametre almayan bir delegatedir.
                                                //bunlara metot bile denmeyip doğruca delegate deniyormuş.

    public delegate void DelegateOrnek2(int sayi1, int sayi2);        //geriye değer döndürmeyen ve 2 parametre alan delegate

    //public delegate void Delegat eOrnek3(int intParam, string stringParam, bool boolParam1, bool boolParam2);
    //yazım sıralamasının bir önemi var.

    public delegate void Islemler(int sayi1, int sayi2);
    public event Action<int,int> _myEvent;
    

    private void Awake()        //unityde referans alacağımız zaman awakete alacağız event konusunda startta aldırmaz.
                                //Sebebi: uygulama başlamadan önce hazırlık yaptığı için orada yapılıyor
                                //kalıtım almak örnek almak sistemsel bir  işlemdir bunlar orada olmalı.
    {
        
        Islemler _do2 = new Islemler(ikiParametreAlanOrnek1);       // parantez içerisine referans alacağı metotu gösteriyoruz
                                                                    // ve ek olarak onu kullanıyor.
        
        _do2 += ikiParametreAlanOrnek2;         // delegatelerde böyle kullanılır 
        _do2 += ikiParametreAlanOrnek3;
        _do2 += ikiParametreAlanOrnek4;
        //_do2(15, 5);
    }
    private void Start()
    {
        
    }


    void ikiParametreAlanOrnek1(int sayi1, int sayi2)       //parametreye verdiğimiz isim önemli değilmiş.
    {
        int sonuc = sayi1 + sayi2;
        Debug.Log(sonuc);
    }
    void ikiParametreAlanOrnek2(int sayi1, int sayi2)       //parametreye verdiğimiz isim önemli değilmiş.
    {
        int sonuc = sayi1 - sayi2;
        Debug.Log(sonuc);
    }
    void ikiParametreAlanOrnek3(int sayi3, int sayi4)       //parametreye verdiğimiz isim önemli değilmiş.
    {
        int sonuc = sayi3 * sayi4;
        Debug.Log(sonuc);
    }
    void ikiParametreAlanOrnek4(int sayi1, int sayi2)       //parametreye verdiğimiz isim önemli değilmiş.
    {
        int sonuc = sayi1 / sayi2;
        Debug.Log(sonuc);
    }


    //tekrar edersek basit düzeyde mmorpgmizi yazacak konuma geleceğizz - Davut Askar
}
