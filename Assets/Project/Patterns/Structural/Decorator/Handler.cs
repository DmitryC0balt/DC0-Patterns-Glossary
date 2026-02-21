using UnityEngine;

namespace Patterns.Structural.DecoratorPattern
{
    public class Handler : MonoBehaviour
    {
        //Один из лучших паттернов, если нужно динамически расширить изначальному объекту его функциональные возможности,
        //хорошо работает при применении перков, абилок, баффов, снаряжения и прочей выкладки


        private Component _component;
        private Decorator _decoratorA;
        private Decorator _decoratorB;


        private Component _currentComponent;


        private void Start()
        {
            //Инициализируем конкретный объект, который будем "декорировать"
            _component = new SpecificComponent();

            //инициируем "украшение" номер 0
            _decoratorA = new DecoratorA();

            //инициируем "украшение" номер 1
            _decoratorB = new DecoratorB();

            //обновляем статус текущего активного объекта
            _currentComponent = _component;
        }


        private void ModificateComponentA()
        {
            //Модифицируем компонент, оборачиваем его в декоратор А
            _decoratorA.SetComponent(_component);
            _currentComponent = _decoratorA;
        }


        private void ModificateComponentB()
        {
            //Модифицируем объект, оборачиваем в декоратор Б
            _decoratorB.SetComponent(_component);
            _currentComponent = _decoratorB;
        }


        private void MultiplyModification()
        {
            //Модифицируем объект дважды, оборачиваем ранее "сдекорированный" декоратором А объект в декоратор Б
            //(да, так тоже можно) 
            _decoratorA.SetComponent(_component);
            _decoratorB.SetComponent(_decoratorA);
            _currentComponent = _decoratorB;
        }


        private void Update()
        {
            //И здесь уже может быть логика как изначального объекта, так и объекта внутри одной или нескольких "оберток"
            _currentComponent.Operation();
        }
    }
}