using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Damage
{
    public class DamageReduction
    {
        public double DamageReductionNumber { get; private set; }
        public DamageReduction(double damageReduction)
        {
            if (damageReduction < 0)
            {
                throw new ArgumentException("Damage reduction cannot be below 0");
            }
            DamageReductionNumber = damageReduction;
        }
    }
}
