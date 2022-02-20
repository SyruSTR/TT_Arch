using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.EventSystems;

public class Trangle : Figure, IPointerUpHandler, IPointerDownHandler, IPickableTarget
{
    public bool IsBlocked { get; set; }

    public PlayerDataDLC PlayerDataDLC { get; private set; }

    private void Awake()
    {
        PlayerDataDLC = FindObjectOfType<PlayerDataDLC>();
    }

    public void ChangePlayerData()
    {
        PlayerDataDLC.Energy--;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        if (!IsBlocked)
            PickTarget();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
    }
    public void PickTarget()
    {
        _targetController.SelectTarget(this);
        _targetController.ApplyEffect += ApplyTarget_sEffect;
    }

    public void ApplyTarget_sEffect<T>(T targetForTarget) where T : Figure
    {
        if(targetForTarget.GetType() != typeof(Cube)) 
            return;
        if (PlayerDataDLC.Energy <= 0) 
            return;
        ChangePlayerData();
        targetForTarget.Size--;
        targetForTarget.ChangeFigureSize();
        _targetController.ApplyEffect -= ApplyTarget_sEffect;
        Destroy(gameObject);
            
    }
    
}