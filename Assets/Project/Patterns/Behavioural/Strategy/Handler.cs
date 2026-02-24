using UnityEngine;

namespace Patterns.Behavioural.StrategyPattern
{
    public class Handler : MonoBehaviour
    {
        //Ничего необычного, просто паттерн, способный динамически подменить повведение прямо во время исполнения

        
        private IStrategy _contextStrategy;
        private IStrategy _strategyA;
        private IStrategy _strategyB;


        private void SetStrategy(IStrategy strategy)
        {
            _contextStrategy = strategy;
        }


        public void SetStrategyA() => SetStrategy(_strategyA);

        public void SetStrategyB() => SetStrategy(_strategyB);


        private void Start()
        {
            _strategyA = new SpecificStrategyA();
            _strategyB = new SpecificStrategyB();
            SetStrategyA();
        }


        private void Update()
        {
            _contextStrategy.Process();
        }
    }
}