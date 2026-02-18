namespace Patterns.Creational.PrototypePattern
{
    public class SpecificPrototypeB : AbstractPrototype
    {
        public SpecificPrototypeB(int id) : base(id)
        {
        }


        public override AbstractPrototype ClonePrototype()
        {
            return new SpecificPrototypeB(id);
        }
    }
}