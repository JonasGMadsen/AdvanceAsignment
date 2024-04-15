using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Monsters
{
    //El Goblino
    public class Goblin : Monster
    { 
        public Goblin(Position position, double hitpoints, string name) : base(position, hitpoints, name)
        {

        }

        public override Damage.Damage GiveDamage()
        {
            return new Damage.Damage(DamageGenerator.Next(1, 10));
        }

        public override Damage.Damage TakeDamage(Damage.Damage taken)
        {
            HitPoints -= taken.DamageNumber;
            return new Damage.Damage(taken.DamageNumber);
        }
    }
}
