using AdvanceAsignment.Damage;
using AdvanceAsignment.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Protagonist.States
{
    public class WeakednedState :IStateMachine
    {
        public Damage.Damage CalculateGiveDamage(Damage.Damage given, AttackItem? attackItem)
        {
            if (attackItem != null)
            {
                return new Damage.Damage(given.DamageNumber + attackItem.DamageDeal.DamageNumber - 1);
            }
            return new Damage.Damage(given.DamageNumber - 1);
        }
    }
}
