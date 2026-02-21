using System.Collections.Generic;

namespace Patterns.Structural.CompositePattern
{
    public class Composite : Component
    {
        //Данный экземпляр представлят собой гибрид паттернов "Observer" и "Decorator"
        private List<Component> _componentList;

        public Composite(string componentName) : base(componentName)
        {
            _componentList = new List<Component>();
        }         
        


        public override void Process()
        {
            
        }


        public override void Add(Component component)
        {
            
        }


        public override void Remove(Component component)
        {
            
        }
    }
}