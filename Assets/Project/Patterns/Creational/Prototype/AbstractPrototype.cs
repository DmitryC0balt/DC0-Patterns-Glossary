namespace Patterns.Creational.PrototypePattern
{
    public abstract class AbstractPrototype
    {
        public int id{ get; private set;}

        public AbstractPrototype(int id)
        {
            this.id = id;
        }


        public abstract AbstractPrototype ClonePrototype();
    }
}