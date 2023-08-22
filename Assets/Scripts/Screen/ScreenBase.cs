using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using DG.Tweening;
namespace Screens
{
    public enum ScreenTypes
    {
        Panel,
        Info_Panel,
        Shops
    }
    public class ScreenBase : MonoBehaviour
    {
        public ScreenTypes screenTypes;
        public List<Transform> listOfObjects;
        public bool startedHided;
        [Header("Animation")]
        public float delayBetweenObjects;
        public float animationDuration = .3f;
        private void Start()
        {
            if (startedHided)
            {
                HideObjects();
            }
        }

       [Button]
       protected virtual void Show()
        {
            ShowObjects();
            Debug.Log("Show");
        }
        [Button]
        protected virtual void Hide()
        {
            Debug.Log("Hide");
            HideObjects();
        }
        private void ShowObjects()
        {
            for(int i=0; i < listOfObjects.Count; i++)
            {
                var obj = listOfObjects[i];
                obj.DOScale(1, animationDuration).SetDelay(delayBetweenObjects*i);
                obj.gameObject.SetActive(true);
                //obj.localScale = new Vector3(1, 1, 1);
            }
        }
        private void ForceShowObjects()
        {
            listOfObjects.ForEach(i => i.gameObject.SetActive(true));
        }
        private void HideObjects()
        {
            listOfObjects.ForEach(i => i.DOScale(0, animationDuration).SetDelay(delayBetweenObjects));
            listOfObjects.ForEach(i => i.gameObject.SetActive(false));
        }

    }
}
