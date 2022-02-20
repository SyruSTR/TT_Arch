using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.EventSystems;


//Класс треугольника
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
        TargetController.SelectTarget(this);
        TargetController.ApplyEffect += ApplyTarget_sEffect;
    }
    //Применения еффекта треугольника
    public void ApplyTarget_sEffect<T>(T targetForTarget) where T : Figure
    {
        //Цель НЕ куб? Обрываем метод)
        if(targetForTarget.GetType() != typeof(Cube)) 
            return;
        //А у вас есть энергия?))) Нет?!?!?! ОБРЫВАЕМ МЕТОД!!!!!
        if (PlayerDataDLC.Energy <= 0) 
            return;
        //Изменяем значение игрока
        ChangePlayerData();
        //Уменьшаем значение размера куба
        targetForTarget.Size--;
        //Изменяем размер куба
        targetForTarget.ChangeFigureSize();
        //Отписываемся от Евента
        TargetController.ApplyEffect -= ApplyTarget_sEffect;
        //Не забёдем уничтожить треугольник, как в ТЗ)
        Destroy(gameObject);
            
    }
    
}