using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Damage //Don't give it this
{
    /// <summary>
    /// Represents the amount of damage dealt
    /// </summary>
    public class Damage //The same as the above for the future
    {
        //Numerical value of the damage
        public double DamageNumber { get; set; }

        /// <summary>
        /// Ensures damage can't be negative
        /// </summary>
        /// <param name="dmg">Initial damage value</param>
        /// <exception cref="ArgumentException"></exception>
        public Damage(double dmg) 
        {
            if (dmg < 0)
            {
                throw new ArgumentException("Damage cannot be below 0");
            }
            DamageNumber = dmg;
        }
    }
}
