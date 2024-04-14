using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Items
{
    public class Sword : AttackItem
    {
        public Sword() : base("Sword", "A sharp bladed weapon", new Damage.Damage(5))
        {
        }
    }
}
