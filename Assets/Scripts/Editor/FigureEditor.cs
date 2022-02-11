using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEditor;
using UnityEngine;

//[CustomEditor(typeof(Figure))]
[CustomEditor(typeof(Figure),true)]
public class FigureEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Figure figure = (Figure) target;

        figure.Size =  EditorGUILayout.IntSlider(figure.Size, 1,50);
        figure.ChangeFigureSize();
        //figure.ChangeFigureSize(figure.Size);
    }
}
