namespace Patterns.Behavioural.StatePattern
{
    public abstract class State
    {
        protected Context _context;

        public State(Context context)
        {
            _context = context;
        }

        public abstract void SwitchState();
        public abstract void Process();
    }
}
