using UnityEngine;

namespace Patterns.Behavioural.VisitorPattern
{
    public class VisitorB : Visitor
    {
        public override void VisitElementA()
        {
            //Что происходит при посещении, сценарий А
        }


        public override void VisitElementB()
        {
            //Что происходит при посещении, сценарий Б
        }


        //Здесь не будет привязки к конкретным элементам - просто потому что элементами может быть вызван любой сценарий посетителя
    }
}