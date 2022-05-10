using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegerTipReferansTip : MonoBehaviour
{
    int[] values3 = { 1, 2, 3 };


    void Start()
    {
    }

    void Update()
    {

    }

    void ReferansTipler()
    {
        //----------------------------------------BURASI ÇOKOMELLİ---------------------------------//
        //Referans tipler 

        //tüm koleksiyonlar bir referans tiptir.
        //string tipinde bir values1 adında bir dizi oluşturduk.
        //bu dizinin ram kaynak adresi Ram201 olsun.
        //Ram201'de values1 saklanacak.
        string[] values1 = { "istanbul", "izmir", "ankara" };

        //Ram202'de values2 saklanacak.
        //string tipinde bir values2 adında bir dizi oluşturduk.
        //bu dizinin ram kaynak adresi Ram202 olsun.
        string[] values2 = { "adana", "diyarbakır", "bursa" };

        values2 = values1;      // burada biz değişkenlerin kaynak kodlarını birbirine eşitledik. 
                                // değişkenlerin değerlerini değil.
                                //burada biz referans tiplerin değerlerini değil, direkt ram kaynak adresini atadık.



        values1[0] = "bodrum";

        Debug.Log(values1[0]);      //      Çıktısının bodrum istanbul olacağını düşündük.
        Debug.Log(values2[0]);      //      Fakat bodrum bodrum yazıldı.
                                    //referans tipte yazdığımız için gidip birbirlerinin ramlarini kullandılar. 

        Debug.Log(values1[1]);      // İZMİR 
        Debug.Log(values2[2]);      // ANKARA 
                                    //----------------------------------------BURASI ÇOKOMELLİ------------------------------------//
    }

    void DegerTipler()
    {
        //Değer Tipler 

        //Ram'ın stack alanında tutulur.

        int sayi1 = 10;  // burada integer tipinde değeri 10 olan sayi1 değişkeni oluşturduk.

        //Ram101 ram kaynak kodu olsun.

        int sayi2 = sayi1;
        sayi1++;

        Debug.Log("Sayi1 => " + sayi1);     // sonuç = 11
        Debug.Log("Sayi2 => " + sayi2);     // sonuç = 10
                                            //burada ram'ın stack kısmında tutulduğu için referans tiplerdeki gibi davranmadı.
    }
    
}
