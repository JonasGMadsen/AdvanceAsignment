using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Monsters
{
    public class GoblinFactory
    {
        public Goblin CreateGoblin(Position position, int hitpoints, string name = "Goblin")
        {
            Goblin goblin = new Goblin(position, hitpoints, name);

            World.Instance.AddObjectToWorld(goblin);
            return goblin;
        }
    }
}
