using UnityEngine;

namespace Patterns.Behavioural.StatePattern
{
    public class StateA : State
    {
        public StateA(Context context) : base(context)
        {
        }


        public override void Process()
        {
            throw new System.NotImplementedException();
        }
        

        public override void SwitchState()
        {
            throw new System.NotImplementedException();
        }
    }
}