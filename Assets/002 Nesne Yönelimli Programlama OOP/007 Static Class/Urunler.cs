using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Urunler
{
    int normalField;
    static int _staticField;

    public int NormalProp { get; set; }
    public static int StaticProp { get; set; }

    public int ID { get; set; }
    public string ItemAdi { get; set; }
    public decimal ItemFiyati { get; set; }

    void NormalMetot()
    {
        //int a = 5;
        //normal metotlar içlerine normal ve static fieldlar alabilirler.
        normalField = 15;
        _staticField = 02;
    }
    static void StaticMetot()
    {
        //static int b = 6; local değişken alamazlar
        //statik metotlar içlerine normal field alamazlar.
        //normalField = 10;//hata verir.
        _staticField = 30;
    }

    public override string ToString()   /*bu polymorfizmdi netten araştır.*/       //ToString'i override yaptık.
    {
        return $"ID:{ID} Name: {ItemAdi} fiyati: {ItemFiyati:C2}";           
        //yazdırma metotu    //burada string ifade döndermemiz lazım.
    }
}
