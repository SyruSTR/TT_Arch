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
        //Если в памяти был другой игровой объект, удаляем его со сцены, он нам больше не нужен
        if (_currentLevelGameObject != null)
        {
            Destroy(_currentLevelGameObject);
        }

        //Берём нужный уровень, и создаём его на сцене)
        var levelPrefab = _levelsData.GetLevel(levelId);
        if (levelPrefab != null)
            _currentLevelGameObject =
                Instantiate(levelPrefab, Vector3.zero, Quaternion.identity, transform);
        else
            Debug.LogError($"Уровня с ID: {levelId}  - не существует!!!!");
            
        
        
    }
    
}
