using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateOrnek2 : MonoBehaviour
{
    public delegate void Ornek2(int sayi1, int sayi2, string str, bool bo);

    void Awake()
    {
        Ornek2 orn2 = new Ornek2(Toplama);
        orn2 += Cikarma;
        orn2 += Carpma;
        orn2 += Bolme;
        orn2(5,10,"alo ben Mert",true);
    }

    void Update()
    {

    }

    void Toplama(int sayi1, int sayi2, string str, bool bo)
    {
        str = "toplama";
        int sonuc = sayi1 + sayi2;
        Debug.Log(str + sonuc);
    }
    void Cikarma(int sayi1, int sayi2, string str, bool bo)
    {
        str = "Cikarma";
        int sonuc = sayi1 - sayi2;
        Debug.Log(str + sonuc);
    }
    void Carpma(int sayi1, int sayi2, string str, bool bo)
    {
        str = "Carpma";
        int sonuc = sayi1 * sayi2;
        Debug.Log(str + sonuc);
    }
    void Bolme(int sayi1, int sayi2, string str, bool bo)
    {
        str = "Bolme";
        int sonuc = sayi1 / sayi2;
        Debug.Log(str+sonuc);
    }
}
