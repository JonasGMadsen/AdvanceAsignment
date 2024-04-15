using AdvanceAsignment.Damage;
using AdvanceAsignment.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Protagonist.States
{
    public class WeakednedState : IStateMachine
    {
        public Damage.Damage CalculateGiveDamage(Damage.Damage given, AttackItem? attackItem)
        {
            if (attackItem != null)
            {
                return new Damage.Damage(given.DamageNumber + attackItem.DamageDeal.DamageNumber - 5);
            }
            return new Damage.Damage(given.DamageNumber - 5);
        }

        public Damage.Damage CalculateTakeDamage(Damage.Damage taken, DefenceItem? defenceItem)
        {
            if (defenceItem != null)
            {
                return new Damage.Damage(taken.DamageNumber - defenceItem.DamageReduction.DamageReductionNumber + 1);
            }
            return new Damage.Damage(taken.DamageNumber + 1);
        }
    }

}
