using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Ornek1Main : MonoBehaviour    
{
    [SerializeField] InputField _itemAdiField, _itemAdediField;
    [SerializeField] Button _ekleButton;

    ////yontem1

    //List<string> _silahListesi1 = new List<string> ();

    ////yontem1



    /// <yontem2>


    //List<Silah> _silahListesi1 = new List<Silah>();


    /// <yontem2>

    //yontem3

    //List<object> _silahListesi = new List<object>();

    //yontem3

    //yontem4
    //List<object> _silahListesi = new List<object>();


    public void Start()
    {
        //ListeyeEkle();
    }
    public void ListeyeEkle(/*yontem3 string _silahAdi,int _silahAdedi*/)
    {
        ////yontem1
        //Silah _silah = new Silah(_itemAdiField.text, System.Convert.ToInt32(_itemAdediField.text));
        //_silahListesi1.Add(_silah.Dondur());
        
        //foreach (var item in _silahListesi1)
        //{
        //    Debug.Log(item);
        //}
        ////yontem1
        ///


        //yontem2
        //Silah _silah = new Silah(_itemAdiField.text, System.Convert.ToInt32(_itemAdediField.text));
        //_silahListesi1.Add(_silah);
        //foreach (var item in _silahListesi1)
        //{
        //    Debug.Log($"Silah adı {item.ItemAdi}    Silah Adedi {item.ItemAdet}");
        //}
        //yontem2


        //yontem3

        //_silahListesi.Add(new Silah(_silahAdi,_silahAdedi));

        //yontem 4

        //Silah _silah = new Silah(_itemAdiField.text, System.Convert.ToInt32(_itemAdediField.text));
        //_silahListesi.Add(_silah);
        //Debug.Log($"ad: {_silah.ItemAdi} adet: {_silah.ItemAdet}");
        
        
        //yöntem 4


    }

    //public void ListeyeEkleBtn()
    //{
    //    ListeyeEkle(_itemAdiField.text, Convert.ToInt32(_itemAdediField.text));
    //    foreach (var item in _silahListesi)
    //    {
    //        Debug.Log(item.ToString());
    //    }
    //}



    

    //parse komutu her şeyi stringe dönüştürür.
}
