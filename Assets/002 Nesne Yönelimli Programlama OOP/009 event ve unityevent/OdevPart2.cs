using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdevPart2 : MonoBehaviour
{
    [SerializeField] OdevPart1 _OdevEvent;
    int sayi=0;
    private void OnEnable()
    {
        _OdevEvent.MyEvent += Begum;
    }
    private void OnDisable()
    {
        _OdevEvent.MyEvent -= Begum;
    }
    public void Begum()
    {
        Debug.Log(sayi++);
    }
} 
