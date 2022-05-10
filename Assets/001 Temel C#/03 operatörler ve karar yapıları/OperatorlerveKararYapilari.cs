using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorlerveKararYapilari : MonoBehaviour
{
    int c;

    [SerializeField] private int sayi = 10;
    private string ay;

    #region aritmetik operatorler
    //ARİTMETİK OPERATÖRLER

    //+, -, *, /, ++, --, VE % aritmetik operatorlerdir.

    //çarpma bölme mod operatörleri aynı satırdaysa işlem önceliği olur Fakat *, /, % operatörlerinin + ve - operatörlerine göre önceliği vardır. 
    #endregion

    #region karsilastirmaOperatorleri

    // C#'ta 6 adet karşılaştırma operatörü vardır. Bunlar : 
    // < küçüktür 
    // > büyüktür 
    // <= küçük eşittir
    // >= büyük eşittir
    // == sadece eşittir.
    // != Eşit değilse


    #endregion

    #region mantiksalOperatorler

    //   3 adet mantıksal operatör bulunmaktadır.
    //   && "ve"operatörü
    //   || "veya operatörü"
    //   !  "değilse operatörü"

    #endregion

    #region atamaOperatoru

    // = (atama operatörü) herhangi bir değişkene bir değer atamak için kullanılır.

    //  İşlemli Atama Operatörleri
    //  *=
    //  +=
    //  -=
    //  /=
    //  &=  Ödev
    //  ^= Ödev
    //  |=  Ödev

    //  a = a/b
    //  a/= b
    //  a^=c

    #endregion


    #region ifElseKararYapisi
    void SayiKontrolu()
    {
        if (sayi < 10)//bool olacak içerisi
                      //bir if şartı sağlanıyorsa diğer else if leri veya elseleri sorgulamaz. Eğer if if yaparsak hepsini sorgular.
        {
            Debug.Log("sayi 10dan küçük");
        }
        else if (sayi == 10)
        {
            Debug.Log("sayi 10dur");
        }
        else
        {
            Debug.Log("sayi 10dan büyük");
        }
        
        
        //***Ternary İF***

                     //sorgu       //true              //false  
        Debug.Log(sayi == 10 ? "sayi 10a eşit" : "sayi 10a eşit değil");


        

    }


    #endregion

    #region switchCaseYapisi

    void AyKontrolu()
    {
    
        switch (ay)
        {
            case "Ocak":
                Debug.Log("Ocak Ayı");
                Debug.Log(ay + " Ayı");
                Debug.Log($"{ay} Ayı");
                break;  //kır ve çık

            case "Şubat":
                Debug.Log("Şubat Ayı");
                break;  //kır ve çık

            default:
                Debug.Log("hiçbir sonuç karşılanmadı.");
                break;

        }
    }


    #endregion


    void Start()
    {
        bool a = true;
        bool b = false;

        a = a ^ b;
        Debug.Log(a);
        a ^= a;
        Debug.Log(a);
       // a /= b;
       // Debug.Log(a);
        a &= a;
        Debug.Log(a);
        a &= b;
        Debug.Log(a);
        a |= b;
        Debug.Log(a);
        a |= a;
        Debug.Log(a);

        //Hesapla2();
    }



    void Update()
    {

    }

    //void Hesapla()
    //{
    //    if (sayi == 10)
    //    {
    //        Debug.Log("sayı 10'a eşittir");
    //    }
    //    else if (sayi <= 10)
    //    {
    //        Debug.Log("sayi 10'dan küçüktür veya eşittir .");
    //    }
    //    else if (sayi > 10)
    //    {
    //        Debug.Log("sayi 10'dan büyüktür.");
    //    }
    //    else
    //    {
    //        Debug.Log("sayi 10 değildir.");
    //    }

    //void Hesapla2()
    //{
    //    switch (sayi)
    //    {
    //        case < 10:
    //            Debug.Log("sayi 10dan küçük");
    //            break;
    //        case > 10:
    //            Debug.Log("sayi 10dan büyük");
    //            break;
    //        case 10:
    //            Debug.Log("sayi 10'a eşit");
    //            break;
    //    }
    //}
}
