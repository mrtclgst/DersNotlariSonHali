using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Araba   
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public bool SifirMi { get; set; }
    public float Hizi { get; set; }
    public int KapiSayisi { get; set; }
    public decimal Fiyati { get; set; }
    public decimal ToplamFiyati { get; set; }

    public virtual void SatisYap()
    {
        ToplamFiyati = Fiyati;
        if (SifirMi)
        {
            ToplamFiyati += 18000m;
            Debug.Log(ToplamFiyati);
        }
    }
     void UlasilmazMetot() 
    { 

    }
}
