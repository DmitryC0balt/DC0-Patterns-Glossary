using UnityEngine;

namespace Patterns.Behavioural.VisitorPattern
{
    public class ObservableA : Observable
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElementA();
            //Можно сделать передачу каких-либо вводных данных посетителю
        }
    }
}
