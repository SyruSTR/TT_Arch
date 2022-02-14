

    using UnityEditor;
    using UnityEngine;

    [CustomEditor(typeof(LevelRedactorDLC))]
    public class LevelRedactorDLCEditor : Editor
    {
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
