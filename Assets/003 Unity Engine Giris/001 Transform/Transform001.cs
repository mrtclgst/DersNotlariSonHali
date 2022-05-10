using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform001 : MonoBehaviour
{
    /*
        Transform : Transform componenti, unity hiyerarsisinde ekledigimiz her objede olmak zorunda.

        Transformsuz bir gameObject dusunulemez. Transformlar unity evreninde ;objenin pozisyonunu hangi yöne baktığını ve boyutunu belirlemek için kullanılır.

        Position : X,Y,Z koordinatları
        Rotation : X,Y,Z eksenleri etrafındaki donusu, derece cinsinden.
        Scale    : X,Y,Z eksenleri boyunca objelerin olcegi.

        */

    private void Start()
    {
        //Genel Kullanimi (klavyeden bir tusa basildiginda)

        transform.position += new Vector3(0.2f, 4f);
        transform.rotation = new Quaternion(90, 45, 0, 0);
        transform.localScale += new Vector3(0, 0, 0);
    }
}
