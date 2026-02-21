namespace Patterns.Structural.FacadePattern
{
    public class Facade
    {
        private SubSystemA _subSystemA;
        private SubSystemB _subSystemB;
        private SubSystemC _subSystemC;


        public Facade(SubSystemA subSystemA, SubSystemB subSystemB, SubSystemC subSystemC)
        {
            _subSystemA = subSystemA;
            _subSystemB = subSystemB;
            _subSystemC = subSystemC;
        }


        public void ActionA() => _subSystemA.ActionA();

        public void ActionB() => _subSystemB.ActionB();

        public void ActionC() => _subSystemC.ActionC();
    }
}