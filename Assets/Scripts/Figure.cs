using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figure : MonoBehaviour
{
    public int Size = 100;
    private RectTransform _rectTransform;

    public virtual void ChangeFigureSize()
    {
        
        GetComponent<RectTransform>().sizeDelta = new Vector2(Size*20, Size*20);
    }

    public void Start()
    {
        
    }
}
