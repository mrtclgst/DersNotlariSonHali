using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastHit : MonoBehaviour
{
    bool _atesEt;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _atesEt = true;
        }
    }
    private void FixedUpdate()
    {
        IsinGonder(transform);
    }
    void IsinGonder(Transform _transform)
    {
        RaycastHit2D hit2D = Physics2D.Raycast(_transform.position, _transform.forward);
        if (hit2D.collider!=null)
        {
            Debug.Log("Işının çarptığı obje=>"+hit2D.collider.tag);
            hit2D.transform.GetComponent<SpriteRenderer>().color = Color.red ;
            if (_atesEt)
            {
                Destroy(hit2D.collider.gameObject);
            }
        }
        _atesEt = false;
    }
}
