using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Damage
{
    public interface IDamageReduction
    {
        public abstract Damage TakeDamage(Damage taken);
    }
}
