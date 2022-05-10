using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProfilBilgileri : MonoBehaviour
{
    [SerializeField] Text oyuncubilgileri, serverbilgileri1, serverbilgileri2, serverbilgileri3, adminbilgi;
   

    void Start()
    {
        StartDuzen();
    }

    void OyuncuBilgileri(string oyuncuAdi, string oyuncuSoyadi,string oyuncuNick,int oyuncuID,bool banDurumu)
    {
        //string bandurum;
        //if (banDurumu==true)
        //{
        //    bandurum = "oyuncu banli";
        //}
        //else
        //{
        //    bandurum = "oyuncu bansız";
        //}
        oyuncubilgileri.text = (" oyuncu adı: " + oyuncuAdi + " oyuncu soyadi: " + oyuncuSoyadi +  " oyuncu nick: " 
            + oyuncuNick + " oyuncu id: " + oyuncuID + " oyuncu ban durumu: " +((banDurumu)? "banlı":"bansız"));
    }

    void ServerBilgileri(string server)
    {
        serverbilgileri1.text = ("server adı: " + server);
    }

    void ServerBilgileri(int ipAdres,int macAdres)
    {
        serverbilgileri2.text = (" ip adres: " + ipAdres + " mac adres: " + macAdres);
    }

    void ServerBilgileri(bool svDurumu, int oyuncuSayi,int permaBanSayi,int macBanSayi)
    {
        //string serverdurum;
        int banSayisi;
        //if (svDurumu==true)
        //{
        //    serverdurum = "acik";
        //}
        //else
        //{
        //    serverdurum = "kapali";
        //}
        banSayisi = permaBanSayi + macBanSayi;
        serverbilgileri3.text = ("server durum: " + ((svDurumu)? "server açık":"server kapalı") + " oyuncu sayısı: " + oyuncuSayi + 
            " ban sayısı: " + banSayisi + " perma ban sayi: " + permaBanSayi + " mac ban sayi:" + macBanSayi);
    }

    void AdminBilgisi(string adminAd, string adminSoyad, int adminYas, string adminAdres, int adminTelefon)
    {
        adminbilgi.text = ("admin ad " + adminAd + " admin soyad: " + adminSoyad + " admin yas: " + adminYas + " admin adres: " + adminAdres + " admin telefon: " + adminTelefon);
    }

    void StartDuzen()
    {
        OyuncuBilgileri("mert","cilgasit", "light", 007, false);
        ServerBilgileri("EU1");
        ServerBilgileri(1,2);
        ServerBilgileri(true, 500,77,33);
        AdminBilgisi("ali", "veli", 49, "feshane", 5555555);
    }

    private int Metot2(int sayi1, int sayi2)    //parametre almayan ama değer döndüren metot!
    {
        int a = sayi1;
        //int sayi1 = 10;
        sayi2 = 20;
        int sonuc = sayi1 + sayi2;
        return a;
    }


}