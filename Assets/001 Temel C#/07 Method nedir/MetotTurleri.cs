using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MetotTurleri : MonoBehaviour
{
    //parametre almıyorsa metot isimleri unique olmalıdır.

    int sayi1;
    int tas1, tas2;

    private void Start()
    {
        int value = Metot2();//değer döndüren metot böyle kullanılır.

        Method6(1, 2, 3, 4, 5);
        //Method4(5);     //sonucu 15 olarak verecektir.
        //Method5(new int[2]);
        //Method5();
        //Method6(new string[3]);


        int sayi100=10;
        int sayi200 = 200;
        Method7(out sayi100, sayi200);

        
    }


    void Metot1()           // bu metot parametre almayan ve değer döndürmeyen bir metottur.
    {

    }


    public int Metot2()    //parametre almayan ama değer döndüren metot!
    {
        int sayi1 = 10;
        int sayi2 = 20;
        int sonuc = sayi1 + sayi2;
        return sonuc;
    }

    void Metot3(int sayi1, int sayi2)    //parametre alan metotlar ! 
    {
        int sonuc = sayi1 + sayi2;
        Debug.Log(sonuc);
    }

    //iki metot3ün ram kaynak kodları farklı olduğu için karışmıyor.

    void Metot3(int sayi1, int sayi2, int sayi3)        //aldığı parametre sayısını arttırabiliyoruz.
    {
        int sonuc = sayi1 + sayi2 + sayi3;
        Debug.Log(sonuc);
    }
    //void Metot3(double sayi1, double sayi2)       //oluyor ama hiç böyle kullanılmıyormuş.
    //{
    //    double sonuc = sayi1 + sayi2;
    //}

    void ProfilBilgileriniGuncelle(string username, int id, bool info, int plaka)
    {

    }

    ////void Deneme()       //tas1 ve tas2ye taşıyıcı değişken deniyor: veriyi bir yerden bir yere taşıyorlar.
    ////{
    ////    Method5(100, 200);
    ////    Debug.Log("sayi1:"+tas1+"sayi2:"+tas2);
    ////}

    ////void Method5(int sayi12,int sayi13)
    ////{
    ////    tas1 = sayi12;
    ////    tas2 = sayi13;
    ////}
    ///
    void Method4(int sayi3 = 10, int sayi4 = 10)  // bunlara default parametreler deniyor.
                                                  // böyle yaptığımızda start'ta Method4(); yazdığımız taktirde
                                                  // default parametre değerleri olarak sayıları getirir koyar.

    {
        int sonuc = sayi3 + sayi4;
        Debug.Log(sonuc);
    }


    void Method5(params int[] sayi)//params ile istediğimiz kadar veri girişi yapabiliyoruz.
    {
        //sayi[0] = 50;
        //sayi[1] = 60;

        int sonuc = 0;
        sonuc = sayi.Sum(); //foreach yerine kullanılabilir.
        Debug.Log(sonuc.ToString());


        //foreach (var item in sayi)
        //{
        //    Debug.Log(item);
        //}

        //foreach (var item in sayi)
        //{
        //    sonuc = sonuc + item;
        //    sonuc += item;
        //}
    }


    void Method6(string[] kelime)
    {
        kelime[0] = "mihrap";
        kelime[1] = "kayra";
        kelime[2] = "baran";

        foreach (var item in kelime)
        {
            Debug.Log(item);
        }
    }

    void Method6(params int[] kelime)//params keywordu n kadar dizi elemanı girilmesini sağlar.
    {
        foreach (var item in kelime)
        {
            Debug.Log(item);
        }
    }

    void Method7(out int sayi100, int sayi200)
    {    
        //out benden ilk değer istemez.
        sayi100 = 10;
        Debug.Log("sayi 1 " + sayi100 + " sayi 2:  " + sayi200);

        //           !!!!!!!!!! ref , out ve params  keywordlerini araştır. !!!!!!!!!!!
    }


    //void Method7(ref int sayi100, int sayi200)
    //{

    //ref benden ilk değer ister.
    //    sayi100 = 10;
    //    Debug.Log("sayi 1 " + sayi100 + " sayi 2:  " + sayi200);

    //    //           !!!!!!!!!! ref, out ve param keywordlerini araştır. !!!!!!!!!!!
    //}
}
