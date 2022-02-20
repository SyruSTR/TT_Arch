using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.EventSystems;

//Класс для хранения информации о игроке для DLC
public class PlayerDataDLC : MonoBehaviour
{
    private int _energyCount;
    
    public delegate void PlayerHandler(int currentEnergyCount);

    public event PlayerHandler ChangeEnergy;

    public int Energy
    {
        get => _energyCount;
        set
        {
            if (_energyCount <= 0) return;
            _energyCount = value;
            ChangeEnergy?.Invoke(_energyCount);

        }
    }

    public void SetStartEnergy(int countEnergy)
    {
        _energyCount = countEnergy;
        ChangeEnergy?.Invoke(_energyCount);
    }
    
}