using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErisimBelirleyiciler : MonoBehaviour
{
    #region C# Erişim Belirleyiciler

    //Erişim Belirleyiciler (Access Modifiers)

    //private : gizli olan değerleri tanımlamak için kullandığımız erişim belirleyicisidir. Sadece kendi bulunduğu " class " içerisinden erişilebilir.
    //Eğer yazdığımız kodda değiştirilmemesini istediğimiz alanlar varsa buraları private yapmamız gerekir.

    //public : Verilen değerlere sınıflardan da erişilmesini ve düzenlenebilmesini sağlar.
    //elimizden geldiğince private değişkenini kullanacağız.

    //protected : Verilen değeri korumalı hale getirir. Sadece aynı sınıftan türeyen sınıflar tarafından kullanılabilir.

    //internal : Aynı program içerisinden erişilebilir. Farklı bir program içerisinden erişilemez. farklı solutionlar arasından çağrılamaz. 

    //tüm bu aşağıdaki methodlar yukarıdaki class'ın içerisinde 


    void Method5()
    {

    }

    private void Method1()
    {

    }

    public void Method2()
    {

    }

    protected void Method3()
    {

    }

    internal void Method4()
    {

    }
    #endregion

    #region Unity Erişim Belirleyiciler 

    [SerializeField] private int sayi = 1;  //böyle yaptığımız zaman sadece biz görebiliyoruz. Yalnız private yaptığımız zaman görünmüyor. Private olmasına rağmen editörde görebiliyoruz.
    [HideInInspector] public int sayi2;     //public bir değişken unityde görünmüyor.
    //[SerializeField]  public olsun olmasın tüm değerlerin inspector'de görünmesini sağlar
    //[HideInInspector]  ise public girilen değerlerin, inspectorde gizlenmesini sağlar.

    #endregion

    //ctrl + k + s ile region oluşturabiliyoruz. kodları böyle yaptığımız zaman kodlar çalışırmış. Commenttedeki gibi olmuyor
    //ctrl + k + d ile boşlukları syntax'ı düzeltiyor.
    //optionsta c# ı seçip word wrapı tikli hale getiriyoruz.

}
