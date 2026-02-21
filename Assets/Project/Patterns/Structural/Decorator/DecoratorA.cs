namespace Patterns.Structural.DecoratorPattern
{
    public class DecoratorA : Decorator
    {
        public override void Operation()
        {
            //Модифицируем
            base.Operation();
        }
    }
}

