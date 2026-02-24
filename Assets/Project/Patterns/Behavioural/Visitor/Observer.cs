using System.Collections.Generic;


namespace Patterns.Behavioural.VisitorPattern
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


        public void VisitObservable(Visitor visitor)
        {
            foreach (var observable in _observableList)
            {
                observable.Accept(visitor);
            }
        }
    }
}