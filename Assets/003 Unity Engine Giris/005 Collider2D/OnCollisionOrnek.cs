using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionOrnek : MonoBehaviour
{
    /*Collider en temeliyle unity oyun motoru icinde kullandigimiz objelerin birbirlerinin icerisinden gecmesini onleyen veya birbirinin icinden gecip gecmedigini algilamamizi saglayan fizik motoruyla beraber kullandigimiz bir yapidir. 
     *Collider bilesenlerini nesnelere bir katilik bir cerceve kazandiran bir bilesen olarakta gorebiliriz 
     */
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Carpti");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Carpisma bitti");
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("carpisma halinde olunan obje");
    }
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("obje icine girdi");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("obje objenin icinden cikti");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("obje diger objenin icinde bulunmaya devam ediyor");
    }
}
