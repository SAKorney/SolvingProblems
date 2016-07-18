using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    class Character
    {
        protected IWeaponBehavior weaponBehavior;
        public string CharacterName { get; protected set; }

        public void SetWeapon(IWeaponBehavior weapon)
        {
            weaponBehavior = weapon;
        }

        public virtual void Fight()
        {
            Console.WriteLine("Атака персонажа: {0}", CharacterName);
            weaponBehavior.useWeapon();
        }
    }

    class Warrior : Character
    {
        public Warrior()
        {
            SetWeapon(new SwordBehavior());
            CharacterName = "Warrior";
        }

        public override void Fight()
        {
            base.Fight();
        }
    }

    class Thief: Character
    {
        public Thief()
        {
            CharacterName = "Thief";
            SetWeapon(new KnifeBehavior());
        }

        public override void Fight()
        {
            base.Fight();
        }
    }

    class Troll: Character
    {
        public Troll()
        {
            CharacterName = "Troll";
            SetWeapon(new AxeBehavior());
        }

        public override void Fight()
        {
            base.Fight();
        }
    }
}
