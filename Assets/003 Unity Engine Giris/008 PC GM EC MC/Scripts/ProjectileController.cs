using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ProjectileController : MonoBehaviour
{
    int coinValue=1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("RedDragon"))
        {
            GameManager._instance.ChangeSkor(coinValue);
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
