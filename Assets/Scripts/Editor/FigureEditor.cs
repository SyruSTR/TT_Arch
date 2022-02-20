using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEditor;
using UnityEngine;

//[CustomEditor(typeof(Figure))]
[CustomEditor(typeof(Figure),true)]
public class FigureEditor : Editor
{
    //Метод для отрисовки GUI в Inspector
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Figure figure = (Figure) target;

        if (GUILayout.Button("Изменить размер"))
        {
            figure.ChangeFigureSize();
        }
    }
}