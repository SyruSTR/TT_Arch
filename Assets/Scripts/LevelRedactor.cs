using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRedactor : MonoBehaviour
{
    [SerializeField] private GameObject CirclePrefab;
    [SerializeField] private GameObject CubePrefab;

    //Без него, нет возможности отключить скрипт
    private void Start()
    {
        
    }

    private void CreateFigure(GameObject prefab,int size)
    {
        Figure newFigure = Instantiate(prefab, Vector3.zero, Quaternion.identity, transform).GetComponent<Figure>();
        newFigure.Size = size;
        newFigure.ChangeFigureSize();
    }
    public void CreateFiguresPair(int size)
    {
        CreateFigure(CirclePrefab, size);
        CreateFigure(CubePrefab,size);
    }
}