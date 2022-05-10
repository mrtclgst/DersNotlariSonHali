using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Silah : Itemler
{
    public Silah(string SilahAdi, int SilahAdet)            //constaki bilgileri abstracttakilerle eşleştirmem gerekiyor.
    {
        ItemAdi = SilahAdi;
        ItemAdet = SilahAdet;
    }

    ////yontem1
    //public string Dondur()
    //{
    //    return $"Silah adi {ItemAdi} Adet: {ItemAdet}";
    //}
    ////yontem1

    public string Text1 { get; }
    public string Text2 { get; }
}
