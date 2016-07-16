using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstorFactory
{
    abstract class  Monster
    {
        public string Name { get; private set; }

        public Monster(string name="Monster")
        {
            Name = name;
        }

        public void GetName()
        {            
            Console.WriteLine("{0} : {1}", GetType().ToString(), Name);
        }
    }

    class Sceleton: Monster
    {
        public Sceleton(string name = "Sceleton") : base(name) { }
    }

    class Orc: Monster
    {
        public Orc(string name = "Orc") : base(name) { }
    }
}
