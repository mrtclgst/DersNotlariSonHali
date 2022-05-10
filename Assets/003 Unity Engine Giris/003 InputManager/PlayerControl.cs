using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] float _hiz;

    private void Update()
    {
        float yatay = Input.GetAxis("Horizontal")*_hiz;
        float dikey = Input.GetAxisRaw("Vertical") * _hiz;      //getaxisraw direkt olarak durdurur

        //yatay *= Time.deltaTime;    //her bilgisayardaki hareket ayni olsun diye.
        //update ile fixedUpdate bizim move speedimize göre fazla hizli kaliyor
        //time.deltatime saniyeyle islem yaptiriyor.

        transform.position += new Vector3(yatay*Time.deltaTime, dikey*Time.deltaTime);

        

    }
}
