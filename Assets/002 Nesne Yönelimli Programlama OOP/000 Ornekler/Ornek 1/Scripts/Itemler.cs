using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Itemler : IItem
{
    public bool ListeyeEklensinMi { get ; set ; }
    public string ItemAdi { get; set; }
    public int ItemAdet { get; set; }

    //yontem3

    //public override string ToString()
    //{
    //    return $"Silah Adı:{ItemAdi} Adet: {ItemAdet}"; 
    //}
}
