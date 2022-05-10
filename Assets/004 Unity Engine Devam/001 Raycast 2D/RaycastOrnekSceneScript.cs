using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RaycastOrnekSceneScript : MonoBehaviour
{
    [SerializeField] Transform _tHor, _tVer;
    [SerializeField] Transform _playerTransform;
    RaycastHit2D raycastHit2DUp;
    RaycastHit2D raycastHit2Down;
    RaycastHit2D raycastHit2Right;
    RaycastHit2D raycastHit2Left;
    RaycastHit2D[] _raycastHit2Ds;

     void Awake()
    {
        //_raycastHit2Ds[0] = raycastHit2DUp;
        //_raycastHit2Ds[1] = raycastHit2Down;
        //_raycastHit2Ds[2] = raycastHit2Right;
        //_raycastHit2Ds[3] = raycastHit2Left;
    }
    void FixedUpdate()
    {
        raycastHit2DUp = Physics2D.Raycast(_tVer.position, _tVer.forward, Mathf.Infinity);
        raycastHit2Down = Physics2D.Raycast(_tVer.position, -_tVer.forward, Mathf.Infinity);
        raycastHit2Right = Physics2D.Raycast(_tHor.position, _tHor.right, Mathf.Infinity);
        raycastHit2Left = Physics2D.Raycast(_tHor.position, -_tHor.right, Mathf.Infinity);
        
        Debug.DrawRay(_tVer.position, -_tVer.forward, Color.red);
        Debug.DrawRay(_tVer.position, _tVer.forward, Color.red);
        Debug.DrawRay(_tHor.position, _tHor.right, Color.red);
        Debug.DrawRay(_tHor.position, -_tHor.right, Color.red);
        Rotate();

        foreach (RaycastHit2D item in _raycastHit2Ds)
        {
            if (item.collider!=null)
            {
                Debug.Log(item.collider.name);
            }
        }
    }
    void Rotate()
    {
        if (Input.GetKey(KeyCode.E))
        {
            _playerTransform.Rotate(0, 0, -100 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            _playerTransform.Rotate(0, 0, 100 * Time.deltaTime);
        }
    }
}
