namespace Patterns.Creational.PrototypePattern
{
    public class SpecificPrototypeA : AbstractPrototype
    {
        public SpecificPrototypeA(int id) : base(id)
        {
            
        }


        public override AbstractPrototype ClonePrototype()
        {
            return new SpecificPrototypeA(id);
        }
    }
}