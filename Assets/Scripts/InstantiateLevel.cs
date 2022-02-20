using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateLevel : MonoBehaviour
{
    private LevelsData _levelsData;
    private GameObject _currentLevelGameObject;

    private void Awake()
    {
        _levelsData = FindObjectOfType<LevelsData>();
        
    }
    

    public void CreateLevel(int levelId)
    {
        if (_currentLevelGameObject != null)
        {
            Destroy(_currentLevelGameObject);
        }

        var test = _levelsData.GetLevel(levelId);
        _currentLevelGameObject = Instantiate(_levelsData.GetLevel(levelId), Vector3.zero, Quaternion.identity, transform);
        
    }
    
}
