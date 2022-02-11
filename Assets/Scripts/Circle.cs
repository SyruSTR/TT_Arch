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
        if (_targetController.CurrentTarget.Size == Size)
        {
            _targetController.CurrentTarget.transform.position = transform.position;
            _targetController.CurrentTarget.GetComponent<Cube>().IsBlocked = true;
            _targetController.ClearTarget();
        }
    }
}