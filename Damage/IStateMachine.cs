using AdvanceAsignment.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Damage
{
    public interface IStateMachine
    {
        Damage CalculateGiveDamage(Damage given, AttackItem? offensiveItem);
        Damage CalculateTakeDamage(Damage taken, DefenceItem? defensiveItem);

    }
}
