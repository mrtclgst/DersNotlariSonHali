using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputOrnek : MonoBehaviour
{
    #region GetKey
    /*
    Input sinifinin metotlariyla kullanicidan tum girdileri aldirabiliriz. 
    Genellikle True False cevabi dondugu icincogunlukla if bloklarinin kullanildigini goruruz.

 */
    /*private void FixedUpdate()
    {
        //getkey metotu: kullanicinin klavye uzerinden belirtilen tusa basilip basilmadigini tespit etmek icin kullanilir.
        if (Input.GetKey("a"))//keycode olarakta a'yi cagirabiliriz.
        {
            Debug.Log("kullanici A tusuna basti.");
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("kullanici S tusuna basti.");
        }

        //GetKeyDown metotu : tusa bastigimiz zaman bir kere calisir.       GetKey ise basili tuttugun surece algiliyor calisiyor.

        if (Input.GetKeyDown("space"))
        {
            Debug.Log("kullanici space (bosluk) tusuna basti.");
        }

        //GetKeyUp metotu : tustan elimizi kaldirdigimiz zaman calisir. 

        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("kullanici D tusundan elini cekti.");
        }
    }*/
    #endregion



    #region GetMouseButton
    /* 
 //GetMouseButton

     Mouse uzerinde yer alan tuslara basili tutulup tutulmadigini kontrol eder.



     if (Input.GetMouseButton(0))// 0, 1, 2 (sol, sağ, orta) 
     {
         Debug.Log("mouse'ta sol tus basildi.");
     }
      Input.GetMouseButtonUp     ve     Input.GetMouseButtonDown       GetKey'deki down ve up komutlariyla ayni calisir */
    #endregion.

    #region GetAxis
    
    /* GetAxis : Unity Oyun motorunun bazi standart yonlendirme islemleri icin varsayilan olarak gelen "Input Manager yapisi bulunur.
       GetAxis metodu ile bu hazir yapilara erisebilir ya da kendi olusturdugumuz yapilari kullanabiliriz.
     */
    #endregion
}

