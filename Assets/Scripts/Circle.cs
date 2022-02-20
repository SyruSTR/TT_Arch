using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.EventSystems;

public class Circle : Figure, IPickableForTarget , IPointerDownHandler , IPointerUpHandler
{
    //Без него не работает OnPointerUp, печаль беда
    public void OnPointerDown(PointerEventData eventData)
    {
        
    }
    //Когда мы кликаем по объекту, то мы его выбираем целью для применения эффекта
    public void OnPointerUp(PointerEventData eventData)
    {
        
        if (TargetController.CurrentTarget != null)
            PickForTarget();
    }
    
    //Передаём Figure контроллеру, ничего более
    public void PickForTarget()
    {
        TargetController.SelectForTarget(this);
    }
}