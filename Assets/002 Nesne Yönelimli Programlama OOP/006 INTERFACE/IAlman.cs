using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAlman      //default olarak publictir. başına bir şey yazmadığım zaman public oluyor.
{
    public bool AlmanMi { get; set; }       // içerisine prop yazabiliyorum.

    public bool MercedesMi { get; set; }

    public void AlmanIndirimiYap();         //böyle yazığımız zaman program bize kızmıyor

    public void AlmanMercedesIndirimiYap();

    //public void AlmanIndirimiYap{} deseydim hata verirdi.

    //check BMW
}


public interface IFransız
{ 
    public bool FransizMi { get; set; }

}
