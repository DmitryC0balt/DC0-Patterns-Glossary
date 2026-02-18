namespace Patterns.Creational.FactoryPattern
{
    public class SpecificFactoryB : Factory
    {
        //Здесь может быть конструктор

        public override Product CreateProduct()
        {
            return new ProductB();
        }
    }
}