namespace Patterns.Structural.CompositePattern
{
    public abstract class Component
    {
        protected string _componentName;

        public Component(string componentName)
        {
            _componentName = componentName;
        }

        public abstract void Process();
        
        public virtual void Add(Component component) {}
        public virtual void Remove(Component component) {}
    }
}