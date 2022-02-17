using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerDataDLC : MonoBehaviour
{
    private int _energyCount;
    
    public delegate void PlayerHandler(int currentEnergyCount);

    public event PlayerHandler ChangeEnergy;

    public int Energy
    {
        get { return _energyCount; }
        set
        {
            if (_energyCount >0)
            {
                _energyCount = value;
                ChangeEnergy?.Invoke(_energyCount);
                
            }

        }
    }

    public void SetStartEnergy(int countEnergy)
    {
        _energyCount = countEnergy;
        ChangeEnergy?.Invoke(_energyCount);
    }
    
}