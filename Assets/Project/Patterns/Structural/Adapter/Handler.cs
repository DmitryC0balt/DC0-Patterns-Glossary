using UnityEngine;

namespace Patterns.Structural.AdapterPattern
{
    public class Handler : MonoBehaviour
    {
        //Преобразовать что-то одно в что-то другое или что-то в этом роде - это здесь,
        //на случай, если надо каким то "чудом" связать функционал пары-другой библиотек

        private Target _target;
        private Adaptee _adaptee;


        void Start()
        {
            //Инициалищируем то, то надо адаптировать
            _adaptee = new Adaptee();

            //Инициализируем то, для чего надо адаптировать
            _target = new Adapter(_adaptee);

            //Как мы уже успели заметить, класс-адаптер наследуется
            //от целевого класса, к которому должна производиться адаптация. Воть.

            //Заставляем адаптироваться...
            Request(_target);
        }


        void Update()
        {
            
        }


        private void Request(Target target)
        {
            target.Request();
        }
    }
}