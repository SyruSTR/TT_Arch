using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(LevelRedactor),false)]
public class LevelRedactorEditor : Editor
{
    [SerializeField]
    private int sizeFigures;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        
        sizeFigures = EditorGUILayout.IntField(sizeFigures);
        LevelRedactor levelRedactor = (LevelRedactor) target;
        if (GUILayout.Button("Создать пару Круг\\Квадрат"))
        {
            levelRedactor.CreateFiguresPair(sizeFigures);
        }
    }
}
