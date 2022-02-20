using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Хранилище префабов уровней
public class LevelsData : MonoBehaviour
{
    [SerializeField] private GameObject[] LevelsPrefabs;
    // Start is called before the first frame update

    //Позволяем взять необходимый уровнь по ID
    public GameObject GetLevel(int levelId)
    {
        if (levelId < 0) return null;
        return levelId >= LevelsPrefabs.Length ? null : LevelsPrefabs[levelId];
    }
}
