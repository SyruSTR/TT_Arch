using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LevelRedactorDLC : MonoBehaviour
{
    private bool IsActive;
    [SerializeField] private GameObject _tranglePrefab;

    private void Start()
    {
        
    }

    public void CreateTrangle()
    {
        Figure newFigure = Instantiate(_tranglePrefab, Vector3.zero, Quaternion.identity, transform).GetComponent<Figure>();
        newFigure.Size = 5;
        newFigure.ChangeFigureSize();
    }
}
