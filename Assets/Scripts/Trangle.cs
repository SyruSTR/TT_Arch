using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.EventSystems;

public class Trangle : Figure, IPointerUpHandler, IPointerDownHandler, IPickableTarget
{
    public bool IsBlocked { get; set; }
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
        if(targetForTarget.GetType() != typeof(Cube)) return;
        targetForTarget.Size--;
        targetForTarget.ChangeFigureSize();
        _targetController.ApplyEffect -= ApplyTarget_sEffect;
        Destroy(gameObject);
    }
    
}