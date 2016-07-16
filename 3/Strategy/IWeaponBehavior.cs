using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    interface IWeaponBehavior
    {
        void useWeapon();
    }

    class SwordBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Удар мечём");
        }
    }

    class KnifeBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Удар ножом"); 
        }
    }

    class AxeBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Удар топором");
        }
    }

    class BowAndArrowBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            throw new NotImplementedException();
        }
    }


}
