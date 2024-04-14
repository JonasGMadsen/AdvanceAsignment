using AdvanceAsignment.Damage;
using AdvanceAsignment.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Protagonist.States
{
    public class NormalState : IStateMachine
    {
        public Damage.Damage CalculateGiveDamage(Damage.Damage given, AttackItem? attackItem)
        {
            if (attackItem != null)
            {
                return new Damage.Damage(given.DamageNumber + attackItem.DamageDeal.DamageNumber);
            }
            return new Damage.Damage(given.DamageNumber);
        }

        public Damage.Damage CalculateTakeDamage(Damage.Damage taken, DefenceItem? defenceItem)
        {
            if (defenceItem != null)
            {
                return new Damage.Damage(taken.DamageNumber - defenceItem.DamageReduction.DamageReductionNumber);
            }
            return taken;
        }
    }
}
