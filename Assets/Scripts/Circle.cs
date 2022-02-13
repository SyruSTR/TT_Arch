using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.EventSystems;

public class Circle : Figure, IPickableForTarget , IPointerDownHandler , IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (_targetController.CurrentTarget != null)
            PickForTarget();
    }
    
    public void PickForTarget()
    {
        _targetController.SelectForTarget(this);
    }
}