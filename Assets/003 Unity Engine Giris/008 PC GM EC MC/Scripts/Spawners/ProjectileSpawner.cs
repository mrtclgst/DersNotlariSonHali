using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] MoveCompanent _mermi;
    [SerializeField] GameObject _body;
    bool _atesEt;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _atesEt = true;
        }
        MermiSpawner();
    }
    private void MermiSpawner()
    {
        if (_atesEt)
        {
            Instantiate(_mermi, _body.transform.position, transform.rotation, this.transform);
            _atesEt = false;
        }
    }
}
