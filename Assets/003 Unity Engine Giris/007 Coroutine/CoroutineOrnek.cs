using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineOrnek : MonoBehaviour
{
    /*          Coroutine
     
     Bu fonksiyonun en cok kullanim sekli projemizdeki bir kodu belli bir zaman sonra baslatmaktir.
     Coroutineler yazilan bir metotun bitmesini bekleyebilir ve daha sonra bekledigi metot islemini bitirdikten sonra bir sonraki metota gecer.
     
     */

    [SerializeField] SpriteRenderer _circle1, _circle2, _circle3;
    private void Start()
    {
        StartCoroutine(TrafikLambasi());
    }
    IEnumerator TrafikLambasi()
    {
        yield return new WaitForSeconds(5);     //w8 for sec'ten inheritance aldık.
        Kirmizi();
        yield return new WaitForSeconds(1);
        Sari();
        yield return new WaitForSeconds(3);
        Yesil();
        yield return new WaitForSeconds(2);
        Sondur();
        StartCoroutine(TrafikLambasi());

    }
    void Kirmizi()
    {
        _circle1.transform.position += new Vector3(1f, 0f);
        _circle1.color = Color.red;
    }
    void Sari()
    {
        _circle2.transform.position += new Vector3(3f, 0f);
        _circle2.color = Color.yellow;
    }
    void Yesil()
    {
        _circle3.transform.position += new Vector3(2f, 0f);
        _circle3.color = Color.green;
    }
    void Sondur()
    {
        _circle1.transform.position -= new Vector3(1, 0);
        _circle2.transform.position -= new Vector3(3, 0);
        _circle3.transform.position -= new Vector3(2, 0);
        _circle1.color = Color.white;
        _circle2.color = Color.white;
        _circle3.color = Color.white;
    }
}
