using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            warrior.Fight();

            Thief thief = new Thief();
            thief.Fight();

            Console.ReadKey();
        }
    }
}
