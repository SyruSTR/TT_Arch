using UnityEngine;
using UnityEngine.EventSystems;

namespace DefaultNamespace
{
    public class Cube : Figure ,IPointerUpHandler, IPointerDownHandler , IPickableTarget , IPickableForTarget
    {
        public bool IsBlocked { get; set; }
        
        
        public override void ChangeFigureSize()
        {
            float newSize = _size*20/Mathf.Sqrt(2);
            GetComponent<RectTransform>().sizeDelta = new Vector2(newSize, newSize);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            
            if (!IsBlocked)
                PickTarget();
        }
        //Без него не хочет работать OnPointerUp
        public void OnPointerDown(PointerEventData eventData)
        {
            
        }

        public void PickTarget()
        {
            _targetController.SelectTarget(this);
        }
        

        public void PickForTarget()
        {
            
        }
    }
}