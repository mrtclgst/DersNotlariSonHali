using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercedes :Araba, IAlman
{
    public Mercedes(string _marka, string _model, bool _sifirMi, float _hizi, int _kapiSayisi, decimal _fiyat)
    //parametre alan metotlar hızlı çalışan metotlardır.
    {
        Marka = _marka;
        Model = _model;
        SifirMi = _sifirMi;
        Hizi = _hizi;
        KapiSayisi = _kapiSayisi;
        Fiyati = _fiyat;
        SatisYap();
    }

    public bool AlmanMi { get; set; }
    public bool MercedesMi { get; set; }
    public bool YuzuyorMu { get; set; }

    public void AlmanIndirimiYap()
    {

    }
    public void AlmanMercedesIndirimiYap() 
    {
        if (MercedesMi)
        {
            ToplamFiyati -= 10000m;
        }
    }
    

    public override void SatisYap()
    {
        ToplamFiyati = Fiyati;
        if (SifirMi)
        {
            ToplamFiyati += 12000m;
        }
        if (YuzuyorMu)
        {
            ToplamFiyati += 44000m;
        }
    }
}
