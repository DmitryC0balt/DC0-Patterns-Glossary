using UnityEngine;

namespace Patterns.Creational.AbstractFactoryPattern
{
    public class Handler : MonoBehaviour
    {

        /// <summary>
        /// 
        /// Если что, этот класс не является руководством к действию "получить что-то с чем-то из чего-то уже на старте",
        /// тут возможен десяток-другой вариантов реализации данного паттерна - например, подмена фабрики, генерация
        /// новых "продуктов" на постоянной основе или через определенные промежутки времени (например, тот же рассадник монстров,
        /// юнитов или тупо спавнер врагов), плюс сами "продукты" могут иметь внутри себя еще какую-либо  логику. Воть.
        /// 
        /// С наилучшими абстрактнофабричными пожеланиями, Dmitry C0balt
        /// 
        /// </summary>

        private AbstractProductA _abstractProductA;//Место для продукта А
        private AbstractProductB _abstractProductB;//Место для продукта Б


        private void Start()
        {
            //Добываем продукты из (Конкретной!) фабрики А
            var factoryA = new ConcreteFactoryA();
            OnInitialization(factoryA);


            //Также добываем продукцию из фабрики Б
            var factoryB = new ConcreteFactoryB();
            OnInitialization(factoryB);
        }


        private void Update()
        {
            OnProcess();
        }


        private void FixedUpdate()
        {
            OnFixedProcess();
        }


        private void LateUpdate()
        {
            OnPostProcess();
        }

#region ABSTRACT_FACTORY_INITIALIZATION


        private void OnInitialization(AbstractFactory factory)
        {
            //Тупо присвоение экземпляров продукции, полученных из фабрики
            _abstractProductA = factory.CreateProductA();
            _abstractProductB = factory.CreateProductB();
        }


        private void OnProcess()
        {
            //Какая-нибудь логика, может быть если "выходящая на свет продукция" 
            //имеет внутри себя какую-нибудь обновляемую логику
        }


        private void OnFixedProcess()
        {
            //Какая-нибудь логика, может быть если "выходящая на свет продукция" 
            //имеет внутри себя какую-нибудь обновляемую в фиксированную единицу времени логику
        }


        private void OnPostProcess()
        {
            //Сюда можно оставить логику на обновление визуала, если таковая есть
        }

#endregion

    }

}