using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Monsters
{
    public static class MonsterFactory
    {

        public static Monster CreateMonster(string type, string name, int hitPoints, int x, int y)
        {
            switch (type.ToLower())
            {
                case "wolf":
                    return new Wolf(name, hitPoints, x, y);

                case "goblin":
                    return new Goblin(name, hitPoints, x, y);

                default:
                    throw new ArgumentException("Invalid monster type");
            }


        }
    }
}
