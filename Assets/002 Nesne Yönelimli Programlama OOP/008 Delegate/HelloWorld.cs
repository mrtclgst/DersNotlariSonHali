using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    double sonuc;
    public delegate void dortIslem(int sayi1, int sayi2);
    private void Awake()
    {
        dortIslem islemler = new dortIslem(Toplama);
        islemler += Cikarma;
        islemler += Carpma;
        islemler += Bolme;
        islemler(15,2);
    }

    void Toplama(int sayi1, int sayi2)
    {
        sonuc = sayi1 + sayi2;
        Debug.Log(sonuc);
    }
    void Cikarma(int sayi1, int sayi2)
    {
        sonuc = sayi1 - sayi2;
        Debug.Log(sonuc);
    }
    void Carpma(int sayi1, int sayi2)
    {
        sonuc = sayi1 * sayi2;
        Debug.Log(sonuc);
    }
    void Bolme(int sayi1, int sayi2)
    {
        sonuc = sayi1 / sayi2;
        Debug.Log(sonuc);
    }
}