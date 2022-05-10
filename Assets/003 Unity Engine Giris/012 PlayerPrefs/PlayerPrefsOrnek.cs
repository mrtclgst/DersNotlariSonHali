using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsOrnek : MonoBehaviour
{
    /*
    PlayerPrefs: Basit duzeyde veri depolamamizi , kaydetmemizi saglayan bir yapidir.
    PlayerPrefs ile oyuncunun yuksek skorunu altin sayisini ya da basit duzeyde uygulama dil seceneklerini tutmak icin kullanilir.
    Ozetle playerprefs ile sahneler arasi veri tasiyabiliriz.

    PlayerPrefs ile int float ve string degerleri tutabilir ve duzenleyebiliriz.

    Playerprefs ile kullanilabilecek fonksiyonlar soyledir:
    DeletaAll : Kayitli tum anahtar ve verileri siler.
    DeleteKey : Belirtilen anahtar ve onunla ilgili her seyi siler.

    GetFloat,GetString,GetInt
    Belirtilen anahtar ile degisken tipindeki veriyi dondurur.
    SetFloat,SetString,SetInt
    Degisken turuyle beraber belirtilen veriyi saklar.

    //playerprefs hileye acik bir ortam ! onemli bilgileri burada tutmayıp google'nin firebase'inde tutmak gerekiyormus.

    */
    // Start is called before the first frame update
    [SerializeField] int sayi;
    [SerializeField] Text sayiText;
    [SerializeField] Text _sayiArttirTxt,_sayiAzaltTxt,_sayiKaydetTxt,_sayiSifirlaTxt;
    
    void Start()
    {
        SayiyiCagir();
        DilGetir();
    }

    private void SayiyiCagir()
    {
        sayi = PlayerPrefs.GetInt("_kaydedilenSayi");
        sayiText.text = sayi.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SayiyiArttir()
    {
        sayi++;
        sayiText.text= sayi.ToString();
    }
    public void SayiyiAzalt()
    {
        if (sayi>0)
        {
            sayi--;
            sayiText.text = sayi.ToString();
        }
    }
    public void SayiSifirla()
    {
        sayi = 0;
        sayiText.text = sayi.ToString();
    }
    public void SayiyiKaydet()
    {
        PlayerPrefs.SetInt("_kaydedilenSayi",sayi);
        sayiText.text = sayi + " " + "degeri kaydedildi. ";
    }
    public void DilKaydet(int diller)
    {
        PlayerPrefs.SetInt("dil", (int)diller);
        DilGetir();
    }
    //public void dilIngilizce()
    //{
    //    PlayerPrefs.SetInt("dil", 1);
    //    DilGetir();
    //}
    //public void dilTurkce()
    //{
    //    PlayerPrefs.SetInt("dil", 0);
    //    DilGetir();
    //}
    void DilGetir()
    {
        int _dil= PlayerPrefs.GetInt("dil");
        if (_dil==(int)Diller.Turkce)
        {
            _sayiArttirTxt.text="sayi artir";
            _sayiAzaltTxt.text="sayi azalt";
            _sayiKaydetTxt.text="sayi kaydet";
            _sayiSifirlaTxt.text="sayi sifirla";
        }
        else if (_dil==(int)Diller.Ingilizce)
        {
            _sayiArttirTxt.text = "increase";
            _sayiAzaltTxt.text = "decrease";
            _sayiKaydetTxt.text = "save";
            _sayiSifirlaTxt.text = "reset";
        }
    }
}
public enum Diller
{
    Turkce, Ingilizce
}
