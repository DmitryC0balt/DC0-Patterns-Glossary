using UnityEngine;

namespace Patterns.Behavioural.StatePattern
{
    public class Context
    {
        private State _currentState;

        public Context(State state)
        {
            _currentState = state;
        }


        public void SetState(State state)
        {
            if (_currentState == state)
            {
                return;
            }

            _currentState = state;
        }


        public void ProcessState()
        {
            _currentState.Process();
        }
    }
}