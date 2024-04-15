using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Damage
{
    /// <summary>
    /// Represents the reduction of damage taken
    /// </summary>
    public class DamageReduction
    {
        //Numerical value of the damage reduction
        public double DamageReductionNumber { get; private set; }
        /// <summary>
        /// Ensures that the reduction value is not negative.
        /// </summary>
        /// <param name="damageReduction">Initial damage reduction value</param>
        /// <exception cref="ArgumentException"></exception>
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
