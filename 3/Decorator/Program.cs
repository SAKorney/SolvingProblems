using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Price currentPrice = new Price();

            DecoratorA decoratorA = new DecoratorA(currentPrice);
            DecoratorB decoratorB = new DecoratorB(decoratorA);

            Console.WriteLine(decoratorB.GetPrice());

            Console.ReadKey();
        }
    }
}
