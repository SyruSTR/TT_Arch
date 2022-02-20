using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DefaultNamespace
{
    public class Cube : Figure ,IPointerUpHandler, IPointerDownHandler , IPickableTarget , IPickableForTarget, IChandedPlayerData
    {
        public bool IsBlocked { get; set; }
        
        
        
        public override void ChangeFigureSize()
        {
            float newSize = size*multiplaySize/Mathf.Sqrt(2);
            GetComponent<RectTransform>().sizeDelta = new Vector2(newSize, newSize);
        }
        
        public PlayerData PlayerData { get; private set; }

        private void Awake()
        {
            PlayerData = FindObjectOfType<PlayerData>();
        }

        public void ChangePlayerData()
        {
            PlayerData.MovesCount++;
        }
        //Когда мы кликаем по объекту, то мы его выбираем целью ИЛИ целью для применения эффекта
        //И мы не можем выбрать данный объект целью, если цель выбрана
        public void OnPointerUp(PointerEventData eventData)
        {
            if(TargetController.CurrentTarget != null)
                PickForTarget();
            else if (!IsBlocked)
                PickTarget();
        }
        //Без него не хочет работать OnPointerUp
        public void OnPointerDown(PointerEventData eventData)
        {
            
        }
        //Запоминаем кто наша цель и какой метод должен сработать, если выбрали цель для Эффекта
        public void PickTarget()
        {
            TargetController.SelectTarget(this);
            TargetController.ApplyEffect += ApplyTarget_sEffect;

        }
        //Применяем эффект Куба
        public void ApplyTarget_sEffect<T>(T targetForTarget) where T : Figure
        {
            //Если целью был не круг, не продалжаем) 
            if(!(targetForTarget is Circle))
                return;
            //Если размеры не совпали, не продолжаем
            if (targetForTarget.Size != Size) 
                return;
            //Переместим Куб в центр Круга
            transform.position = targetForTarget.transform.position;
            //Изменим занчение игрока
            ChangePlayerData();
            //И заблокируем КУб для манипуляций
            IsBlocked = true;
            //Ах да, забыли Куб, как цель)
            TargetController.ClearTarget();
            //И отписались от события, во избежания казусов
            TargetController.ApplyEffect -= ApplyTarget_sEffect;
        }
        

        public void PickForTarget()
        {
            TargetController.SelectForTarget(this);
        }
    }
}