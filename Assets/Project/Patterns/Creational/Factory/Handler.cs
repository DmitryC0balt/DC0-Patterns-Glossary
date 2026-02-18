using UnityEngine;

namespace Patterns.Creational.FactoryPattern
{
    public class Handler : MonoBehaviour
    {
        /// <summary>
        /// 
        /// Определяет интерфейс (или абстрактный класс), "под флагами" которого будут выходить их творения. Но есть нюанс - 
        /// изначально не ясно, что именно это за творения.
        /// 
        /// (Небольшая заметка - что именно может быть произведено, может быть задано в конструкторе конкретной фабрики)
        /// 
        /// </summary>


        private Factory _factoryA;//Место под первую фабрику
        private Factory _factoryB;//Место под вторую фабрику


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Объявляем об открытии первой фабрики
            _factoryA = new SpecificFactoryA();

            //Объявляем об открытии второй фабрики
            _factoryB = new SpecificFactoryB();
        }

        // Update is called once per frame
        void Update()
        {
            //Логика вышла из чата
        }


        private void CreateProductA()
        {
            var product = _factoryA.CreateProduct();
            //Делаем с полученным продуктом что хотим
        }


        private void CreateProductB()
        {
            var product = _factoryB.CreateProduct();
            //Делаем с полученным продуктом что хотим
        }
    }
}