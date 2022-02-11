﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Не пришло в голову как по другому хранить таргет для применения
public class TargetController : MonoBehaviour
{

    public Figure CurrentTarget
    {
        get;
        private set;
    }

    public void SelectTarget(Figure target)
    {
        CurrentTarget = target;
        Debug.Log("Объект выбран");
    }

    public void ClearTarget()
    {
        CurrentTarget = null;
    }
}