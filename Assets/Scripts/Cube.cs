using UnityEngine;
using UnityEngine.EventSystems;

namespace DefaultNamespace
{
    public class Cube : Figure ,IPointerUpHandler, IPointerDownHandler , IPickableTarget , IPickableForTarget
    {
        public bool IsBlocked { get; set; }
        
        
        public override void ChangeFigureSize()
        {
            float newSize = _size*_multiplaySize/Mathf.Sqrt(2);
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
            _targetController.ApplyEffect += ApplyTarget_sEffect;

        }

        public void ApplyTarget_sEffect<Circle>(Circle targetForTarget) where Circle : Figure
        {
            
            if (targetForTarget.Size != Size) return;
            transform.position = targetForTarget.transform.position;
            IsBlocked = true;
            _targetController.ClearTarget();
            _targetController.ApplyEffect -= ApplyTarget_sEffect;
        }
        

        public void PickForTarget()
        {
            
        }
    }
}