using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour       //monobehaviourdan kalıtım almalıdır. çünkü unitynin metotları burada yer almaktadır.
{
    //[Header("İLK ALAN GİRİŞİ")]

    //[SerializeField] InputField firstName, lastName, age;
    //[SerializeField] InputField firstName2, lastName2, age2;
    //[SerializeField] Text resultText;

    void Start()
    {
        insan _insan1 = new insan() { LastName = "10hanelibirsey" };
        Debug.Log(_insan1.LastName);

        
        //_insan1.FirstName = firstName.text;
        //_insan1.LastName = lastName.text;
        //_insan1.Age = System.Convert.ToInt32(age.text);

        //Debug.Log(_insan1.Age);
        #region bombaMain

        //KirmiziBomba _kirmiziBomba = new KirmiziBomba();
        //_kirmiziBomba.BombaAdi = "Kirmiziii";
        //_kirmiziBomba.BombaRengi = "kirmizili";

        //MaviBomba _maviBomba = new MaviBomba();
        //_maviBomba.BombaAdi = "mavi bomb ";
        //_maviBomba.BombaRengi = "mavi";


        #endregion

        //önemli bilgiler base classta belirtilmeli.

        //kapsülleme işlemi new property(probtabtab) de yapılmaz!
        //bir kapsülleme işlemi yapmak istiyorsak işlem yapılacak olan property old property'e dönüştürülmek zorundadır.

        //insan _insan1 = new insan();         // new kısacası örneğini al demek. içindeki değerleri almaz.
        //_insan1.FirstName = "kayra";        //bu main class sayesinde her değişken için yeniden değişken atamaktan kurtulduk.
        //_insan1.LastName = "Çemberci";      //shift+alt kısayolu ile aynı anda n satıra da yazı yazabiliyoruz

        //if (_insan1.Age <0 || _insan1.Age>100)
        //{
        //    Debug.Log("Hatalı bir yaş değeri girdiniz");
        //    _insan1.Age = 18;
        //}
    }
    public void ButtonVeriGonder()
    {

        
        //_insan2.Age= 20;

        #region MyRegion
        //if (_insan1.Age < 0 || _insan1.Age > 100)
        //{
        //    resultText.text = "yaş 0dan büyük 100den küçük olmalı";
        //    _insan1.Age = 18;
        //}
        //else
        //{
        //    resultText.text = "np";
        //} 
        #endregion

        insan _insan2 = new insan();

        //_insan2.FirstName = firstName2.text;
        //_insan2.LastName = lastName2.text;
        //_insan2.Age = System.Convert.ToInt32(age.text);
        //_insan2.Age= 20;

        #region MyRegion
        //if (_insan2.Age < 0 || _insan2.Age > 100)
        //{
        //    resultText.text = "yaş 0dan büyük 100den küçük olmalı";
        //    _insan2.Age = 18;
        //}
        //else
        //{
        //    resultText.text = "np";
        //} 
        #endregion
    }
}
