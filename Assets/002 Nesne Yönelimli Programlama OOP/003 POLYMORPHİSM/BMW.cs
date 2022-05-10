using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMW : Araba, IAlman        //bu aynı zamanda bir newlemedir.   // sadece 1 kalıtım almaya izin veriyor ama istediğim kadar interface alabilirim.
{

    public BMW()
    {
        //bu method burada gözükmese bile arka planda vardır. Bu bir yapıcı metottur. Yapıcı metotlar birden fazla yüklenme (overload) alabilir.
    }
    public BMW(string _marka, string _model)
    {
        Marka = _marka;
        Model = _model;
    }

    //base class olduğu için aynı zamanda metot olma özelliği de taşıyor.
    //istedikten sonra da beni mirasla eşleştir diyor.

    //araba _araba = new araba();       bu kullanım yanlış biz zaten miras almışız. 
    //miras almak zaten newlemek.

    void Deneme(int a=1,int b=32)
    {

    }


    public bool UcuyorMu { get; set; }

    //constructorlar bilgiyi tek seferde okur.
    //hizli okunur.

    public BMW(string _marka, string _model, bool _sifirMi, float _hizi, int _kapiSayisi, decimal _fiyat)
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

    public override void SatisYap()
    {
        ToplamFiyati = Fiyati;
        if (SifirMi)
        {
            ToplamFiyati += 12000m;
        }
        //if (UcuyorMu)
        //{
        //    ToplamFiyati += 44000m;
        //}
        Debug.Log(ToplamFiyati);
    }
   
    /// //////////////////////////////////////////////////////
       //interface kısmı

    public bool AlmanMi { get; set; }
    public bool MercedesMi { get; set ; }

    public void AlmanIndirimiYap()
    {
        if (AlmanMi)
        {
            ToplamFiyati -= 5000m;
        }
    }

    public void AlmanMercedesIndirimiYap()
    {
        
    }

    ///////////////////////////////////////////////////////////////////

    #region BEFORE


    //public override void SatisYap()
    //{
    //    ToplamFiyati = Fiyati;
    //    if (SifirMi)
    //    {
    //        ToplamFiyati += 18000m;
    //    }
    //    if (UcuyorMu)
    //    {
    //        ToplamFiyati += 20000m;
    //    }
    //} 
    #endregion
}
