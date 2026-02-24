using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Behavioural.ObserverPattern
{
    public class Observer
    {
        private List<Observable> _observableList;

        public Observer()
        {
            _observableList = new();
        }


        public void AddObservable(Observable observable)
        {
            _observableList.Add(observable);
        }


        public void RemoveObservable(Observable observable)
        {
            _observableList.Remove(observable);
        }


        public void Process()
        {
            foreach (var observable in _observableList)
            {
                observable.Process();
            }
        }
    }

}
