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
    //После выполнения необходимых функций, компонент выключается
    private void OnEnable()
    {
        //Если на сцене ещё нет уровня, следовательно DLC не может быть включенным,
        //логично? Логично!
        try
        {
            _isActiveDLC = FindObjectOfType<LevelRedactorDLC>().enabled;
        }
        catch (NullReferenceException e)
        {
            _isActiveDLC = false;
        }
        
        //Активируем все необходимые объекты для работы DLC
        foreach (var gm in gameObjectsForDLC)
        {
            gm.SetActive(_isActiveDLC);
        }

        
        
        //Тут немного замудрённо получилось(
        //Меняем anchoredPosition на те, что указали,
        //Чтобы изменить панель игрока под нужные функции
        _panelRectTransform.anchoredPosition = new Vector2(
            _isActiveDLC ? sizeForDLC.x : mainSize.x,
            _panelRectTransform.anchoredPosition.y);
        //Тут тоже самое, DLC активиравано?
        //Применяем необходимые параметры
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