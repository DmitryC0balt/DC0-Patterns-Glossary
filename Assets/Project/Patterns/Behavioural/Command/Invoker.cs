using UnityEngine;

namespace Patterns.Behavioural.CommandPattern
{
    //Источник команды
    public class Invoker
    {
        private Command _command;


        public Invoker(Command command)
        {
            _command = command;
        }


        public void SetCommand(Command command)
        {
            _command = command;
        }


        public void StartCommand()
        {
            _command.Start();
        }


        public void StopCommand()
        {
            _command.Stop();
        }
    }
}