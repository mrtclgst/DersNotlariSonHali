using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main2 :MonoBehaviour
{

    void Start()
    {
        
        //HIZLI İŞLEM
        BMW bmw1 = new BMW("BMW","X5", true,320f,4,150000m);
        //DERLEYİCİ BUNU TEK BİR KOD GİBİ OKUYOR.
        
        bmw1.UcuyorMu = true;
        bmw1.SatisYap();
        //bmw1.Ulasilmaz();
        //bmw1.ToplamFiyati = 10m;
                                //protected yazdığımız için buraya kod ekleme gibi             bir durum oluşmuyor.
                                //Fiyatta oynama yapılamıyor1.

        string aracFiyati = bmw1.ToplamFiyati.ToString();

        //YAVAŞ İŞLEM
        //Mercedes mercedes1 = new Mercedes();
        //mercedes1.Marka = "Mercedes";
        //mercedes1.Model = "SLS AMG";
        //mercedes1.SifirMi = true;
        //mercedes1.Hizi = 500f;
        //mercedes1.KapiSayisi = 2;
        //mercedes1.Fiyati = 350000m;
        //mercedes1.YuzuyorMu= true;
        //bu kod yığını alttaki kod ile aynı.

        Mercedes mercedes1= new Mercedes("Mercedes", "SLS AMG", true, 500f, 2,350000m);//bununla 
        string aracFiyati2 = mercedes1.ToplamFiyati.ToString();

        Toyota toyota1 = new Toyota();
        toyota1.Marka = "Toyota";
        toyota1.Model = "Corolla";
        toyota1.SifirMi = true;
        toyota1.Hizi = 250f;
        toyota1.KapiSayisi = 4;
        toyota1.Fiyati = 100000m;

        Citroen citroen1 = new Citroen();
        citroen1.Marka = "Citroen";
        citroen1.Model = "c4";
        citroen1.SifirMi = false;
        citroen1.Hizi = 250f;
        citroen1.KapiSayisi = 4;
        citroen1.Fiyati = 150000m;
        
    }
}