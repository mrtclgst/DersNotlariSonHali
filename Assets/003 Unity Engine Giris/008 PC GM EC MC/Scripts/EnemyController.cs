using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour  
{
    [SerializeField] float _oyundaKalacagiSure;
    float _currentTime;
    void Start()
    {

    }
    void Update()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime > _oyundaKalacagiSure)
        {
            Destroy(this.gameObject);
        }
    }
}
