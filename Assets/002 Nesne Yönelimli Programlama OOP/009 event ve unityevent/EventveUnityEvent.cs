using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventveUnityEvent : MonoBehaviour
{
    ///                                             <EVENTS>
    /// 
    ///      Eventler tetiklenen olaylardır ve delegatelerden türerler.
    /// 
    ///      Delegatelerin bir tık ötesi eventlardır.
    ///      Örneğin: onClick ve textChange bir eventtir.
    ///      
    ///      Delegateleri konu olarak işlememizin bir nedeni de event yapısını öğrenmektir.
    ///      
    ///      
    ///      
    ///                              Event nasıl yazılır?
    ///      1-) Event yazılması için öncelikle delegate'nin yazılması gerekir. 
    ///      2-) O event içine alacağı metotun ne tür bir metot olduğunu bilmesi gerekir. 
    ///      3-) Delegate referansını metottan alır. Event referansını delegate'ten alır. 
    /// 
    ///      Eventlerde tetikleyicinin ve tetiklenenin ne olduğunu bilmemiz gerekir.
    ///             
    ///             
    /// 
    /// 
    ///
    ///                                             <EVENTS> 


    //public delegate void MyDelegate();      //ilk önce delegate oluşturulur.
    //public event MyDelegate MyEvent;        //sonra oluşturulan delegate'ten event yaratılır.

    public event Action MyEvent;              //geriye değer döndürmeyen ve parametre almayan bir event oluşturmanın kısa yolu.

    public event Action<int, int> MyEvent2;    //geriye değer döndürmeyen ve 2 parametre alan event oluşturmanın kısa yolu
    
    public event Func<string> MyEvent3;       //geriye string değer döndüren ve parametre almayan event oluşturmak.

    public event Func<string, int, bool> MyEvent4;     //bool tipinde geriye değer döndüren int ve string tipinde parametre alan event 
    //bir şey belirtmediğimizde en sağdaki döndürülen değerdir.
    //her oktay tetiklenmesinde 1 artan uygulama yap .

    private void OnEnable()             //unity'nin metotları       
    {

        //if (MyEvent!=null)
        //{
        //    MyEvent.Invoke();         //eventi aktarıyor.
        //}

        MyEvent?.Invoke();      //ternary if        yukarıdaki if in kısa hali      null değilse anlamına geliyor.

        //Debug.Log("obje aktif");        //enable duruma geldiğinde otomatikmen çalışıyor.

        //obje hiyerarşide aktif olduğunda  tetiklenir.

        //kullanıldığı obje için çalışırlar.(hiyerarşide scriptin bağlı olduğu obje için geçerlidir.)
    }
    private void OnDisable()            //unity'nin metotları 
    {
        //Debug.Log("obje pasif");        //disable duruma geldiğinde otomatikmen çalışıyor. 

        //obje hiyerarşide pasif olduğunda tetiklenir

        //kullanıldığı obje için çalışırlar.(hiyerarşide scriptin bağlı olduğu obje için geçerlidir.)
    }

    private void Start()
    {
    //Debug.Log("küsürlü bir sayı olduğunda  stringDeger.toString("0.00") diye yazdığımız zaman bize virgülden sonra 2 hane gösterir")
    }


    //mouse hareketleri bir eventtir.


}
