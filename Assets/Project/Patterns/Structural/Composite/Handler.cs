using UnityEngine;

namespace Patterns.Structural.CompositePattern
{
    public class Handler : MonoBehaviour
    {
        private Component _composite;
        private Component _singleComponent;

        private Composite _build;

        //Компоновщик может быть нужен, если вся реализация должна быть представлена древовидной иерархией, а доступ к ее 
        //частям должен быть на постоянной основе (есть, скажем, боевая машина, состоящая из нескольких узлов, и у каждого
        //узла своя логика...)


        void Start()
        {
            //Создание одиночного компонента
            _composite = new Composite("NewComposite");

            //Создание сборного компонента, внутри которого может быть что-нибудь еще
            _singleComponent = new SingleComponent("NewSingleComponent");

            //Сборка в единое целое
            _build = new Composite("Build");
            _build.Add(_composite);
            _build.Add(_singleComponent);

            //С виду похоже на эдакий гибрид паттернов "Builder", "Observer" и "Decorator", завернутый в одну оболочку,
            //от оригиналов они отличаются относительно небольшими изменениями по структуре и функционалу
        }

       
        void Update()
        {
            //Здесь может быть логика взаимодействия - как с отдельными частями получившейся композиции, так
            //и с самой композицией целиком
        }
    }
}