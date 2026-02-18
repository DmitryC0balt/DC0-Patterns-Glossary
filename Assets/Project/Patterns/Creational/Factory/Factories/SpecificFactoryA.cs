namespace Patterns.Creational.FactoryPattern
{
    public class SpecificFactoryA : Factory
    {
        //Здесь может быть конструктор

        public override Product CreateProduct()
        {
            return new ProductA();
        }
    }
}