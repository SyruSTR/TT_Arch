using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

//Класс для изменения текста
public class TextChanging : MonoBehaviour
{
    [FormerlySerializedAs("_tmpText")] [SerializeField] protected TMP_Text tmpText;
    [FormerlySerializedAs("_pattern")] [SerializeField] protected string pattern;
    private PlayerData _playerData;
    
    // public void ChangeText(string text)
    // {
    //     _tmpText.text = string.Format(_pattern, text);
    // }

    protected void ChangeText(int integerForText)
    {
        tmpText.text = string.Format(pattern, integerForText);
    }
    
    public virtual void Awake()
    {
        tmpText = GetComponent<TMP_Text>();
        _playerData = FindObjectOfType<PlayerData>();
        _playerData.ChangeMoves += ChangeText;
    }

    private void Start()
    {
        //ChangeText(0);
    }
}
