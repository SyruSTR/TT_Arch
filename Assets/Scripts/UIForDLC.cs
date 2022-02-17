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
        _isActiveDLC = FindObjectOfType<LevelRedactorDLC>().enabled;
        Debug.Log("test: "+_isActiveDLC);
    }

    private void Start()
    {
        for (int i = 0; i < gameObjectsForDLC.Length; i++)
        {
            gameObjectsForDLC[i].SetActive(_isActiveDLC);
        }


        _panelRectTransform.anchoredPosition = new Vector2(
            _isActiveDLC ? sizeForDLC.x : mainSize.x,
            _panelRectTransform.anchoredPosition.y);
        _panelRectTransform.sizeDelta = new Vector2(
            _isActiveDLC ? sizeForDLC.y : mainSize.y
            , _panelRectTransform.sizeDelta.y);
    }
}