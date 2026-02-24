namespace Patterns.Behavioural.VisitorPattern
{
    public abstract class Observable
    {
        public abstract void Accept(Visitor visitor);
    }
}