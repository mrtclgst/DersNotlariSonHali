using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRenderer002 : MonoBehaviour
{
    /*
        SpriteRenderer : Unity'de 2D ya da 3D oyunlarda kullanılan oyun nesnelerinde(objelerde) gösterilmek istenen grafik görüntüleridir.
     
        Sprite ile resim birbirleriyle karistirilmamalidir.
        Bir objeye sprite atandiginda otomatik olarak o objeye spriteRenderer componenti eklenir.
     
    
    Sprite : Grafigin secilecegi goruntu yolu
        
    Color  : Renklendirmek icin kullanilir.
    
    Flip   : Sprite'i isaretlenen eksen yonunde dondurur.
    
    Material : Sprite'in dokusu.
    
    Draw Mode: Boyutlari degistirildiginde sprite'in nasil olceklenecegini tanimlar.
               //simple:desen dogrudan uzar        //slice a bak       //tiled : deseni copyalayarak uzatır.

    Mask interaction : Sprite renderer'in bir obje ile etkilesim kurarken nasil davranilacagini belirler. Baska bir obje olusturulur ve ona "sprite mask" özelligi atanarak uygulanir.
    None : Hicbir etkilesimde bulunmuyor.
    Visible Inside Mask : Maskede Gorunur olur. Sprite Sprite maskin kapladigi yerde gorunur
    Visible Outside Mask : Sprite, Sprite maskin disinda gorunur icinde gorunmez.

    Order in Layer : Sprite katman siralamasini belirlemek icin kullanilir.
 
     */
}
