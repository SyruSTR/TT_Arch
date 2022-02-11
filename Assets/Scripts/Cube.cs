using UnityEngine;

namespace DefaultNamespace
{
    public class Cube : Figure
    {
        
        public override void ChangeFigureSize()
        {
            float newSize = Size/Mathf.Sqrt(2);
            GetComponent<RectTransform>().sizeDelta = new Vector2(newSize, newSize);
        }
    }
}