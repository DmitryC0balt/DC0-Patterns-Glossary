namespace Patterns.Structural.BridgePattern
{
    public abstract class Abstraction
    {
        //Оригинальная абстракция

        protected Implementor _implementor;

        public Implementor implementor
        {
            set
            {
                _implementor = value;
            }
        }

        //или

        public void SetImplementor(Implementor newImplementor)
        {
            _implementor = newImplementor;
        }


        public Abstraction(Implementor implementor)
        {
            _implementor = implementor;
        }

        public virtual void Operation()
        {
            _implementor.ImplementOperation();
        }
    }
}