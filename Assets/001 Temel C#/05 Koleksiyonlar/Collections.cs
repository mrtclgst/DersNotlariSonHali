using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour
{
    //Dizi (Array)      dizilerin Lengthi vardır 
    //List 


    [SerializeField]
    int[] ornekDizi2 = new int[3] { 10, 20, 30 };   //yukarıdaki şekill aynı değerleri ver.

    //Serialize Field yaparak dictionaryleri göremiyoruz çünkü unity okumuyor algılamıyor.
    // [SerializeField]
    // List<int> listOrnek = new List<int>();          // inspectorda hem diziler hem de liste görülüyor.

    void Start()
    {
        //ListOrnek();
        QueueOrnek();
    }

    void Update()
    {

    }

    void ArrayOrnek()
    {
        int[] ornekDizi = new int[3];       //içinde 3 tane eleman bulunabilir demek bu 
                                            // inspectorda arraylar görülebiliyor.
        ornekDizi[0] = 10;
        ornekDizi[1] = 20;
        ornekDizi[2] = 30;
        //    ornekDizi[3] = 40;  //hata verir. 



        for (int i = 0; i < ornekDizi.Length; i++)      //dizinin uzunluğunu otomatik olarak algılar.
        {
            Debug.Log(ornekDizi[i]);
        }

        foreach (var item in ornekDizi2)    //sayaç beklemiyor.
        {
            Debug.Log(item);
        }
    }

    void ListOrnek()
    {
        //List<string> listeOrnek = new List<string>();
        //listeOrnek.Add("Kırmızı");
        //listeOrnek.Add("Sarı");
        //listeOrnek.Add("Galatasaray");
        //listeOrnek.Add("Basketbol");

        //kisa yazimi
        //List<int> listeOrnek2 = new List<int>()
        //{ 100, 200, 300, 400, 555, 666, 777 };



        //for (int i = 0; i < listeOrnek.Count; i++)
        //{
        //    Debug.Log(listeOrnek[i]);
        //}

        //foreach (var item in listeOrnek2)   //listeornek2 yazdirma 
        //{
        //    Debug.Log(item);
        //}
    }

    //dictionary list yapısını unity göstermiyor. Odin kullanmak gerekiyor.  

    void DictonaryOrnekleri()
    {
        Dictionary<int, string> dictionaryOrnekleri = new Dictionary<int, string>();

        dictionaryOrnekleri.Add(1, "kalem");
        dictionaryOrnekleri.Add(2, "defter");
        dictionaryOrnekleri.Add(3, "silgi");
        //dictionaryOrnekleri.Add(3, "kazık"); hata verir! 
        dictionaryOrnekleri.Add(4, "kalem");// hata vermez.

        foreach (var item in dictionaryOrnekleri)
        {
            Debug.Log(dictionaryOrnekleri);
        }


        //Dictionary<string, string> dictionaryOrnekleri2 = new Dictionary<string, string>();

        //dictionaryOrnekleri2.Add("araba", "car");
        //dictionaryOrnekleri2.Add("araba", "ferrari");   ////1. değer (key değeri ) unique(benzersiz) olmalı. Yoksa program hata verir çalışmaz.
    }


    void QueueOrnek()
    {

        //Queue koleksiyon yapısında ilk giren ilk çıkar en son giren bilgi ilk çıkar. Count kullanılır.
        //Enqueue => Ekler
        //Dequeue => Çıkartır
        //Queue yapısına bak tekradan.


        Queue<string> gunler = new Queue<string>();//Queue'lerde iki tane veri barındıramıyoruz dictionarydeki gibi. 
        gunler.Enqueue("pazartesi");
        gunler.Enqueue("salı");
        gunler.Enqueue("çarşamba");
        gunler.Enqueue("perşembe");
        gunler.Enqueue("cuma ");

        //foreach (var item in gunler)
        //{
        //    Debug.Log(item);
        //}

        for (int i = 0; i < 5; i++)//gunler.Count dediğimiz durumda yanlış oluyor.
                                   //Cünkü her dequeue yaptığımız zaman countu bir azalıyor bu yüzden bunu döngüde kullanmak yanlış.
                                   
        {
            Debug.Log(gunler.Dequeue());
        }
    }
}
