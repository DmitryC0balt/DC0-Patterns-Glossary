using UnityEngine;

namespace Patterns.Behavioural.CommandPattern
{
    //Конкретный экземпляр команды
    public class SpecificCommand : Command
    {
        private Receiver _receiver;


        public SpecificCommand(Receiver receiver)
        {
            _receiver = receiver;
        }


        public override void Start()
        {
            
        }

        public override void Stop()
        {
            
        }
    }
}