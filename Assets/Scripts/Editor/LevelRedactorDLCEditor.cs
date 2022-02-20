

    using UnityEditor;
    using UnityEngine;

    [CustomEditor(typeof(LevelRedactorDLC))]
    public class LevelRedactorDLCEditor : Editor
    {
        //Метод для отрисовки GUI в Inspector
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            LevelRedactorDLC levelRedactorDlc = (LevelRedactorDLC) target;
            if (GUILayout.Button("Создать треугольник"))
            {
                levelRedactorDlc.CreateTrangle();
            }
        }
    }
