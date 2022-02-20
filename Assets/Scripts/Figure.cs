using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Основной класс для Всех фигур
public class Figure : MonoBehaviour
{

    [SerializeField] protected int size;
    [SerializeField] protected int multiplaySize = 20;

    public int Size
    {
        get => size;
        set => size = value;
    }
    
    

    private RectTransform _rectTransform;
    protected TargetController TargetController;
    
    //Изменяем размер фигуры
    public virtual void ChangeFigureSize()
    {
        float newSize = size * multiplaySize;
        GetComponent<RectTransform>().sizeDelta = new Vector2(newSize, newSize);
    }

    public void Start()
    {
        TargetController = FindObjectOfType<TargetController>();
        ChangeFigureSize();
    }
}