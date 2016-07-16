using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand
{
    class Invoker
    {
        const int sizeArrayCommanand = 3;
        ICommand [] command = new ICommand[sizeArrayCommanand] { new EmptyCommand(), new EmptyCommand(), new EmptyCommand() };

        public void SetCommand(ICommand command, int index)
        {
            if(index < sizeArrayCommanand)
                this.command[index] = command;
        }

        public void Action(int index)
        {
            command[index].Execute();
        }
    }
}
