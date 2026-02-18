using UnityEngine;

namespace Patterns.Creational.PoolPattern
{
    public abstract class PoolableObject : MonoBehaviour
    {
        public void Show()
        {
            gameObject.SetActive(true);
            OnShow();
        }


        public void Hide()
        {
            gameObject.SetActive(false);
            OnHide();
        }


        protected abstract void OnShow();
        protected abstract void OnHide();
    }
}