using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerController014 : MonoBehaviour
{
    Animator _animator;
    void Awake()
    {
        _animator = GetComponent<Animator>();
        //getcomponentchildren'de var.
    }

    void FixedUpdate()
    {
        AttackYap();
        Yuru();
        Zipla();
    }
    void AttackYap()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _animator.Play("knightattack");
        }
    }
    void Yuru()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _animator.Play("knightwalk");
        }
    }
    void Zipla()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _animator.Play("knightjump");
        }
    }
}
