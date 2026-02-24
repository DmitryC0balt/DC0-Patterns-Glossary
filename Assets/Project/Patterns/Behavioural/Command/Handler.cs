using UnityEngine;

namespace Patterns.Behavioural.CommandPattern
{
    public class Handler : MonoBehaviour
    {
        private Invoker _invoker;
        private Receiver _receiver;
        private SpecificCommand _specificCommand;


        private void Start()
        {
            Initialization();
        }


        private void Initialization()
        {
            _receiver = new Receiver();
            _specificCommand = new SpecificCommand(_receiver);
            _invoker = new Invoker(_specificCommand);
        }


        private void SetCommand(Command command)
        {
            _invoker.SetCommand(command);
        }


        private void Update()
        {
            _invoker.StartCommand();
        }
    }
}