using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Класс для взаимодействия между целью И целью для эффекта
//Не пришло в голову, как по другому хранить таргет для применения
public class TargetController : MonoBehaviour
{
    
    
    //Просто запоминаем цель
    public Figure CurrentTarget
    {
        get;
        private set;
    }

    public delegate void TargetsHandler(Figure figure);

    public event TargetsHandler ApplyEffect;
    
    //Метод для запоминания цели
    public void SelectTarget(Figure target)
    {
        CurrentTarget = target;
        Debug.Log("Объект выбран");
    }
    //Метод для выбора цели для эффекта)
    public void SelectForTarget(Figure figure) 
    {
        ApplyEffect?.Invoke(figure);
    }
    //Очищаем цель
    public void ClearTarget()
    {
        CurrentTarget = null;
    }
}
