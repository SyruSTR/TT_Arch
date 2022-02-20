using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIForDLC : MonoBehaviour
{
    private bool _isActiveDLC;
    private RectTransform _panelRectTransform;
    [SerializeField] private GameObject[] gameObjectsForDLC;

    [Space] [Tooltip("X - это X, Y - Ширина")] [SerializeField]
    private Vector2 mainSize;

    [Tooltip("X - это X, Y - Ширина")] [SerializeField]
    private Vector2 sizeForDLC;

    private void Awake()
    {
        _panelRectTransform = GetComponent<RectTransform>();
        
        
    }

    private void OnEnable()
    {
        try
        {
            _isActiveDLC = FindObjectOfType<LevelRedactorDLC>().enabled;
        }
        catch (NullReferenceException e)
        {
            _isActiveDLC = false;
        }
        
        
        foreach (var gm in gameObjectsForDLC)
        {
            gm.SetActive(_isActiveDLC);
        }


        _panelRectTransform.anchoredPosition = new Vector2(
            _isActiveDLC ? sizeForDLC.x : mainSize.x,
            _panelRectTransform.anchoredPosition.y);
        _panelRectTransform.sizeDelta = new Vector2(
            _isActiveDLC ? sizeForDLC.y : mainSize.y
            , _panelRectTransform.sizeDelta.y);
        //Своё отработал, ждёт включения...
        enabled = false;
    }

    private void Start()
    {
        
    }
}