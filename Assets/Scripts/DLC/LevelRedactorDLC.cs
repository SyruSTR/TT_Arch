using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LevelRedactorDLC : MonoBehaviour, IChandedPlayerDataDLC
{
    private bool _isActive;
    [SerializeField] private GameObject tranglePrefab;

    [SerializeField] private int countEnergyForLevel;
    
    public PlayerDataDLC PlayerDataDLC { get; private set; }

    private void Awake()
    {
        PlayerDataDLC = FindObjectOfType<PlayerDataDLC>();
    }

    public void ChangePlayerData()
    {
        PlayerDataDLC.SetStartEnergy(countEnergyForLevel);
    }
    //Без него нет возможности управлять отлючение\включением компонента
    private void Start()
    {
        ChangePlayerData();
    }

    public void CreateTrangle()
    {
        Figure newFigure = Instantiate(tranglePrefab, Vector3.zero, Quaternion.identity, transform).GetComponent<Figure>();
        newFigure.Size = 5;
        newFigure.ChangeFigureSize();
    }
}
