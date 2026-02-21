namespace Patterns.Structural.BridgePattern
{
    public class RefinedAbstraction : Abstraction
    {
        //Абстракция, которая немножечко малость отличается от оригинала
        public RefinedAbstraction(Implementor implementor) : base(implementor)
        {
            
        }


        public override void Operation()
        {
            
        }
    }
}