using UnityEngine;


namespace Patterns.Behavioural.ObserverPattern
{
    public class Handler : MonoBehaviour
    {
        //Если чего-либо много, а на каждый подобный "экземпляр" уходит дофига времени и вычислительных мощностей,
        //просто прокешируй это


        private Observer _observer;
        private Observable _observableA;
        private Observable _observableB;
        private Observable _observableC;



        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _observer = new();
            _observableA = new SpecificObservable();
            _observableB = new SpecificObservable();
            _observableC = new SpecificObservable();

            _observer.AddObservable(_observableA);
            _observer.AddObservable(_observableB);
            _observer.AddObservable(_observableC);
        }



        // Update is called once per frame
        void Update()
        {
            _observer.Process();
        }
    }
}

