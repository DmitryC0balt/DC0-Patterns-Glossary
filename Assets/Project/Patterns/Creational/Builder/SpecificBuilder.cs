namespace Patterns.Creational.BuilderPattern
{
    public class SpecificBuilder : Builder
    {
        private Product _product;

        public SpecificBuilder()
        {
            _product = new();
        }

        public override void BuildPartA()
        {
            _product.AddPart("PartA");
        }

        public override void BuildPartB()
        {
            _product.AddPart("PartB");
        }

        public override void BuildPartC()
        {
            _product.AddPart("PartC");
        }

        public override Product CreateProduct()
        {
            return _product;
        }
    }
}
