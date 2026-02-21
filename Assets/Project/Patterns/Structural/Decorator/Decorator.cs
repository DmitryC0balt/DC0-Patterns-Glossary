namespace Patterns.Structural.DecoratorPattern
{
    public abstract class Decorator : Component
    {
        protected Component _component;

        public void SetComponent(Component component)
        {
            //Ставим уомпонент, который надо "украсить"
            _component = component;
        }


        public override void Operation()
        {
            //Украшаем и воспроизводим, но сначала проверяем наличие...с помощью синтаксического сахара
            _component?.Operation();
        }
    }
}