using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Damage
{
    public class Damage
    {
        public double DamageNumber { get; set; }

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
