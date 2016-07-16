using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstorFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            MonsterFactory monsterFactory = new MonsterFactory();
            Monster sceleton = monsterFactory.SimpleMonsterFactory(typeof(Sceleton));

            sceleton.GetName();
            
            Console.ReadKey();
        }
    }
}
