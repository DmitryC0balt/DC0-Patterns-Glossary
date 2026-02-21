using UnityEngine;

namespace Patterns.Structural.FacadePattern
{
    public class Handler : MonoBehaviour
    {
        //Вообще несложный паттерн, выводящий на "табло" (и одновременно объединяющий) функционал других классов

        private Facade _facade;

        private void Start()
        {
            var subSystemA = new SubSystemA();
            var subSystemB = new SubSystemB();
            var subSystemC = new SubSystemC();

            _facade = new Facade(subSystemA, subSystemB, subSystemC);
        }


        public void UseFacadeA()
        {
            _facade.ActionA();
        }


        public void UseFacadeB()
        {
            _facade.ActionB();
        }


        public void UseFacadeC()
        {
            _facade.ActionC();
        }


        private void Update()
        {
            //Всякая разная логика
        }
    }
}