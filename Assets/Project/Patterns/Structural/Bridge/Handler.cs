using UnityEngine;

namespace Patterns.Structural.BridgePattern
{
    public class Handler : MonoBehaviour
    {
        //Ну тут все просто, есть абстракция, есть реализация, задача - сокрыть их постоянную привязку, чтобы одно
        //можно было менять независимо от другого (чтобы при изменении абстракции реализация не посыпалась)

        //Иногда может оказаться полезным при реализации фильтров и заводов в играх

        private Abstraction _abstraction;

        private void BridgeRealization()
        {
            _abstraction = new RefinedAbstraction(new SpecificImplementorA());
            _abstraction.Operation();

            _abstraction.implementor = new SpecificImplementorB();
            _abstraction.Operation();

            _abstraction.SetImplementor(new SpecificImplementorA());
            _abstraction.Operation();
        }


        private void Start()
        {
            BridgeRealization();
        }


        private void Update()
        {
            
        }
    
    }
}