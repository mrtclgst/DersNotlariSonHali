using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticUrunler //altındaki her şey statik olmak zorunda ! 
{
    public static int ID { get; set; }
    public static string ItemAdi { get; set; }
    public static decimal ItemFiyati { get; set; }

    public static string EkranaYazdir()
    {
        return $"ID:{ID} Name: {ItemAdi} fiyati: {ItemFiyati:C2}";      //C2 para formatidir. tl olarak yazdirir.
    }
}
