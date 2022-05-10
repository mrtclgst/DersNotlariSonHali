using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{


    /// <2.YOL>
    /// 

    //EventveUnityEvent _eventOrnek;

    //private void Awake()
    //{   
    //    _eventOrnek = FindObjectOfType<EventveUnityEvent>();    //hiyerarşi taranır ve EventveUnityEvent taranarak referansı alınır.
    //                                                            //bu işlevin çok yavaş olduğunu unutmayın.
    //                                                            //Çoğu durumda bunun yerine singleton deseninin kullanabilirsiniz.
    //    _eventOrnek=get                                                        
    //}


    /// 2.YOL
    /// 


    ///                         3. YOL
    ///                         


    //EventveUnityEvent _eventOrnek;

    //private void Awake()
    //{
    //    _eventOrnek = GetComponent<EventveUnityEvent>();        //bunu startta kullanmıyoruz


    //}

    ///                 3.YOL



    //------------------------1.  yolu izliyoruz projemizde ----------------------------

    [SerializeField] EventveUnityEvent _eventOrnek;     //1. yol 

    private void OnEnable()
    {
        _eventOrnek.MyEvent += Oktay;                               //event içerisine olayı ekleriz
    }
    private void OnDisable()
    {
        _eventOrnek.MyEvent -= Oktay;                               //event içerisinden olayı çıkarırız.

    }

    void Oktay()
    {
        Debug.Log("tetiklendi.");
    }
}
