using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveCompanent : MonoBehaviour    
{
    [SerializeField] DirectionEnums _enum; 
    Rigidbody2D _rg;
    [SerializeField] float _dusmanHareketHizi;
    void Start()
    {
        _rg = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        _rg.velocity = Dondur() * Time.deltaTime * _dusmanHareketHizi;
    }
    Vector2 Dondur()
    {
        Vector2 _directionVector2;
        if (_enum==DirectionEnums.Left)
        {
            _directionVector2 = Vector2.left;
        }
        else if (_enum==DirectionEnums.Up)
        {
            _directionVector2 = Vector2.up;
        }
        else if (_enum == DirectionEnums.Down)
        {
            _directionVector2 = Vector2.down;
        }
        else
        {
            _directionVector2 = Vector2.right;
        }
        return _directionVector2;
    }
    
}