using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextChanging : MonoBehaviour
{
    [SerializeField] private TMP_Text _tmpText;
    [SerializeField] private string _pattern;
    private PlayerData _playerData;
    
    // public void ChangeText(string text)
    // {
    //     _tmpText.text = string.Format(_pattern, text);
    // }

    public void ChangeText(int integerForText)
    {
        _tmpText.text = string.Format(_pattern, integerForText);
    }
    
    private void Awake()
    {
        _tmpText = GetComponent<TMP_Text>();
        _playerData = FindObjectOfType<PlayerData>();
        _playerData.ChangeMoves += ChangeText;
    }

    private void Start()
    {
        ChangeText(0);
    }
}
