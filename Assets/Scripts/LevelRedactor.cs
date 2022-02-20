using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class LevelRedactor : MonoBehaviour
{
    [FormerlySerializedAs("CirclePrefab")] [SerializeField] private GameObject circlePrefab;
    [FormerlySerializedAs("CubePrefab")] [SerializeField] private GameObject cubePrefab;

    //Без него, нет возможности отключить скрипт
    private void Start()
    {
        
    }
    //Просто создаём фигуру, ничего интересного
    private void CreateFigure(GameObject prefab,int size)
    {
        Figure newFigure = Instantiate(prefab, Vector3.zero, Quaternion.identity, transform).GetComponent<Figure>();
        newFigure.Size = size;
        newFigure.ChangeFigureSize();
    }
    //Мы же создаём пару объектов
    public void CreateFiguresPair(int size)
    {
        CreateFigure(circlePrefab, size);
        CreateFigure(cubePrefab,size);
    }
}