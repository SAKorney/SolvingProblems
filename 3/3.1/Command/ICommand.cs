using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand
{
    interface ICommand
    {
        void Execute();
    }

    class ConcreteCommandOne : ICommand
    {
        ReceiverOne _receiver;

        public ConcreteCommandOne(ReceiverOne receiver)
        {
            this._receiver = receiver;
        }

        public void Execute()
        {
            _receiver.SomethingDoOne();
        }
    }

    class ConcreteCommandTwo : ICommand
    {
        ReceiverTwo _receiver;

        public ConcreteCommandTwo(ReceiverTwo receiver)
        {
            this._receiver = receiver;
        }

        public void Execute()
        {
            _receiver.SomethingDoTwo();
        }
    }

    class EmptyCommand : ICommand
    {
        public void Execute()
        {
     
        }
    }

}
