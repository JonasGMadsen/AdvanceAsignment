using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Monsters
{
    public class Goblin : Monster
    { //need changing
        public Goblin(Position position, int hitpoints, string name) : base(position, hitpoints, name)
        {

        }

        public override Damage.Damage GiveDamage()
        {
            return new Damage.Damage(DamageGenerator.Next(1, 10));
        }

        public override Damage.Damage TakeDamage(Damage.Damage taken)
        {
            throw new NotImplementedException();
        }
    }
}
