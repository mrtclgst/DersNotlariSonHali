using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donguler : MonoBehaviour
{
    //döngüler bizden bir sayaç ister. (foreach haricinde)
    //While //Do While //For //Foreach
    //While, Do while ve For döngülerinde sayaç belirtme zorunluluğu vardır.
    //sayaç index olarak geçer karşılığı i 
    //private değişkenlerin başlarına "_" koyup kütüphaneden çağırıyor gibi hareket edebiliyoruz.

    int sayac2 = 20;

    void WhileDongusu()
    {
        int sayac = 1;
        while (sayac <= 14)    //while+tab+tab yap
        {
            Debug.Log("Calisti");
            sayac++;            //sayac = sayac + 1;     sayac += 1;
        }
    }

    void DoWhileDongusu()
    {
        do
        {
            //While, şart sağlandığında içine bir daha girmez ve çalışmaz. Fakat "do" ile kullanıldığında bir kere çalışır ve devam eder. 
            Debug.Log("Sart Saglansin ya da saglanmasin calisir.");
        } while (false);
    }

    void ForDongusu()   //unityde en çok for ve foreach kullanılır. 
    {

        for (int i = 0; i < sayac2; i++)
        {
            if (i > 2)
            {
                break;      //kır ve çık 0,1,2 yi yazdırır.
            }
        }


        for (int i = 0; i < 10; i++)
        {
            if (i == 2)
            {
                continue;   //2'yi atlayacak
            }
        }
    }
    //void ForEachDongusu()
    //{
    //    foreach (var item in collection)
    //    {

    //    }
    //}



    void Start()
    {
        WhileDongusu();
    }
}
