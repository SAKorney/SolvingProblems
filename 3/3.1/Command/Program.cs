using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker newInvoker = new Invoker();

            newInvoker.SetCommand(new ConcreteCommandOne(new ReceiverOne()), 0);
            newInvoker.SetCommand(new ConcreteCommandTwo(new ReceiverTwo()), 1);

            newInvoker.Action(0);
            newInvoker.Action(1);
            Console.WriteLine("EmptyCommand");
            newInvoker.Action(2);

            Console.ReadKey();
        }
    }
}
