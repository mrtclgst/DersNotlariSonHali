using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdevPart1 : MonoBehaviour
{
    public event Action MyEvent;
    private void OnEnable()
    {
        MyEvent?.Invoke();
    }
    private void OnDisable()
    { 
    }
}
