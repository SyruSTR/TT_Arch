using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figure : MonoBehaviour
{

    [SerializeField] protected int _size;
    [SerializeField] protected int _multiplaySize = 20;

    public int Size
    {
        get { return _size; }
        private set { _size = value; }
    }
    
    

    private RectTransform _rectTransform;
    protected TargetController _targetController;

    public virtual void ChangeFigureSize()
    {
        float newSize = _size * _multiplaySize;
        GetComponent<RectTransform>().sizeDelta = new Vector2(newSize, newSize);
    }

    public void Start()
    {
        _targetController = FindObjectOfType<TargetController>();
        ChangeFigureSize();
    }
}