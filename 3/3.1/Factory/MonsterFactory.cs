using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstorFactory
{
    class MonsterFactory
    {
        private static Type orcType = typeof(Orc);
        private static Type sceletonType = typeof(Sceleton);

        public Monster SimpleMonsterFactory(Type type)
        {          
            if (type == orcType)
                return new Orc();
            else if (type == sceletonType)
                return new Sceleton();

            return null;
        }
    }
}
