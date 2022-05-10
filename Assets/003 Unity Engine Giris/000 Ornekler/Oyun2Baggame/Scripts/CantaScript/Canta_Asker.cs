using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Canta_Asker : Canta
{
    public Canta_Asker(string _turu,int _kapasite,float _dayaniklilik,bool _matTakilabilir,SpriteRenderer _cantaSprite,bool _kamufleEdilebilir)
    {
        Turu = _turu;
        Kapasite = _kapasite;
        Dayaniklilik = _dayaniklilik;
        MatTakilabilir = _matTakilabilir;
        CantaSprite = _cantaSprite;
        KamufleEdilebilir = _kamufleEdilebilir;     //burası buradan geliyor direktmen 
    }
    public bool KamufleEdilebilir { get; set; }
    public void AskerCantasiniGoruntule()
    {
        
    }
}
