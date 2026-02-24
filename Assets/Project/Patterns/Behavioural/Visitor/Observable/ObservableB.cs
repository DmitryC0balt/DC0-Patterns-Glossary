using UnityEngine;

namespace Patterns.Behavioural.VisitorPattern
{
    public class ObservableB : Observable
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElementB();
            //Можно сделать передачу каких-либо вводных данных посетителю
        }
    }
}