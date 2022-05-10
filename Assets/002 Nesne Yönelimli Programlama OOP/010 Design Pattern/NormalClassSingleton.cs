using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgacNormalClassSingleton :MonoBehaviour
{
    private static AgacNormalClassSingleton _instance;  //classın özellikleriyle instance oluştur demek.
    //classtan aldığımız varible 

    public AgacNormalClassSingleton()
    {

    }
    
    

    private void Start()//benim startım
    {
        //AgacNormalClassSingleton _agac =new AgacNormalClassSingleton();//ram kaynağı 200
        //AgacNormalClassSingleton _agac1 =new AgacNormalClassSingleton();//ram kaynağı 201
        //AgacNormalClassSingleton _agac2 =new AgacNormalClassSingleton();//ram kaynağı 202
        //AgacNormalClassSingleton _agac3 =new AgacNormalClassSingleton();//ram kaynağı 203                    
        //AgacNormalClassSingleton _agac4 =new AgacNormalClassSingleton();//ram kaynağı 204

        //her bir new farklı bir referans oluşturur!

        AgacNormalClassSingleton _agac = AgacNormalClassSingleton.OktayInstance();//200
        AgacNormalClassSingleton _agac2 = AgacNormalClassSingleton.OktayInstance();//200
        AgacNormalClassSingleton _agac3 = AgacNormalClassSingleton.OktayInstance();//200
        AgacNormalClassSingleton _agac4 = AgacNormalClassSingleton.OktayInstance();//200
        AgacNormalClassSingleton _agac5 = AgacNormalClassSingleton.OktayInstance();//200
        AgacNormalClassSingleton _agac6 = AgacNormalClassSingleton.OktayInstance();//200
        AgacNormalClassSingleton _agac7 = AgacNormalClassSingleton.OktayInstance();//200
        AgacNormalClassSingleton _agac8 = AgacNormalClassSingleton.OktayInstance();//200
        AgacNormalClassSingleton _agac9 = AgacNormalClassSingleton.OktayInstance();//200

    }
    public static AgacNormalClassSingleton OktayInstance()
    {
        if (_instance==null)//herhangi bir referans taşımıyor ise 
        {
            _instance = new AgacNormalClassSingleton();//classı referans alsın
        }
        return _instance;//mevcut bir referans varsa o referansı dön 
    }
    //bol bol yazmamız lazım pratik yap!
}