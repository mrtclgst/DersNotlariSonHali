using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEnterORnek : MonoBehaviour
{
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("carpisma gerceklesti");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("carpisma sonlandi");
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("carpisma devam ediyor");
    }*/
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
