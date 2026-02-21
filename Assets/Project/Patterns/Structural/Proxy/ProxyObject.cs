namespace Patterns.Structural.ProxyPattern
{
    public class ProxyObject : AbstractObject
    {
        private SpecificObject _specificObject;

        public override void Action()
        {
            _specificObject ??= new SpecificObject();
            _specificObject.Action();
        }
    }
}