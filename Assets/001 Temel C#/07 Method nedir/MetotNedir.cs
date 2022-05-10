using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetotNedir : MonoBehaviour
{
    [SerializeField] string _username;
    [SerializeField] int _can;
    [SerializeField] int _kalkan;
    [SerializeField] string _silahAdi;
    [SerializeField] int _mermiSayisi;
    [SerializeField] int _para;
    [SerializeField] string _takim;
    [SerializeField] bool _banliMi;



    void Start()    // void metot parametre almayan metotlardir. Geriye deger döndürmez.
    {
        // Startın altında ne kadar az metot varsa o kadar güzel.
        //Burası şiir gibi olacak.
        OyunuBaslat();
    }

    void Oyuncu1()
    {
        _username = "baran";
        OyuncuBaslangicDegerleriniOlustur();
    }
    void Oyuncu2()
    {
        _username = "rıdvan";
        OyuncuBaslangicDegerleriniOlustur();
    }
    void Oyuncu3()
    {
        _username = "büşra";
        OyuncuBaslangicDegerleriniOlustur();
    }
    void Oyuncu4()
    {
        _username = "kayra";
        OyuncuBaslangicDegerleriniOlustur();
    }
    void Oyuncu5()
    {
        _username = "japon";
        OyuncuBaslangicDegerleriniOlustur();
    }
    void Oyuncu6()
    {
        
        _username = "semra";
        OyuncuBaslangicDegerleriniOlustur();
    }

    void Oyuncu7()
    {
        _username = "furkan";
        OyuncuBaslangicDegerleriniOlustur();

    }

    void OyuncuBaslangicDegerleriniOlustur()
    {
        //stabil alanları ayırdık.

        _silahAdi = "m4a1-s";
        _can = 100;
        _kalkan = 50;
        _takim = "A takimi";
        _banliMi = false;
        _para = 10;
        Debug.Log("Kullanıcı Adı : " + _username + " Can: " + _can + " Kalkan: " + _kalkan + " Silah: " + _silahAdi + " Takım: " + _takim + " Para: " + _para + " Ban durumu: " +_banliMi);
    }
    void OyunuBaslat()
    {
        Oyuncu1();
        Oyuncu2();
        Oyuncu3();
        Oyuncu4();
        Oyuncu5();
        Oyuncu6();
        Oyuncu7();
    }
}
