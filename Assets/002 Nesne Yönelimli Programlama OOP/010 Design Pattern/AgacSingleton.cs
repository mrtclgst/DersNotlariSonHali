using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgacSingleton : MonoBehaviour  //bu yöntem monobehaviourdan kalıtım alan nesneler için geçerli
{
    public static AgacSingleton Instance { get; private set; }  //classtan instance yarattık
    //class tipinde bir instance oluşturduk. Dışarıdan set edilemesin dedik. 

    private void Awake()
    {
        //awake içerisinde bir kere referans almasını istediğimiz için private kullandık(seti).Dışarıdan alamaz, bir kere ağaç referansını alabilir.
        //private aynı class içinde atama yaptırılabiliyor.

        if (Instance==null)     //newlenmediyse demek       //referans almadıysa demek
            //instance içerisinde referans yok ise demek
        {
            Instance = this;    //bu classın referansını al demek
                                //this (kendisi.buClass). Yani diyoruz ki bu classın referansını bu Instance değişkenine ata 
            DontDestroyOnLoad(this.gameObject);//Yeni bir sahne yüklenirken hedef nesneyi yok etme.
        }
        else
        {//eğer referansımız boş değilse 
            Destroy(this.gameObject);   //Yok et!
        }
    }
    
    //singleton örneği bak ve yap.
}