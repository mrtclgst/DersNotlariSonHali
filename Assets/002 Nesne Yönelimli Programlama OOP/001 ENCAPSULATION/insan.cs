using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class insan      //base class
{
    //private string firstName;
    private string _lastName;              //bu kısım field kısmıdır.
    //private int age;
    //private decimal money;

    //property dediğimiz şeyler değer tutmazlar. Değerleri taşırlar.
    //propertyler : taşıyıcılar 


    //new property          new propta encapsülation yapamam old prop lazım onu yapabilmem için 
    //new propta field kullanamazsın.


    //Kapsülleme (Encapsulation) kavramı bir nesnenin bazı özellik ve işlevlerini başka sınıflardan ve nesnelerden saklamaktır.

    public string FirstName { get; set; }

    public string LastName
    {
        get
        {
            return _lastName;
        }

        set
        {
            if (value.Length < 25)
            {
                //throw new System.Exception("hata lan hata");
                Debug.Log("hataligiris");
               
            }
            else
            {
                _lastName = value;      //value dışarıdan fielddan gelen veriyi lastname2'ye at diyoruz.
            }
        }
    }

    //public int Age { get; set; }

    public decimal Money { get; private set; }

    //OLD PROPERTY yapıyorsak field vermek zorundayız!!!!
    public int Age
    {
        get

        {
            return Age;
        }

        set
        {
            if (value < 0 || value > 100)
            {
                Debug.Log("hatali giris");
            }
            else
            {
                Age = value;
            }

            //Age = value;          
            //gelen veriyi tut içine at
        }
    }
}


//  base class böyle oluşturuluyor.
//  public class insan 
//  {}