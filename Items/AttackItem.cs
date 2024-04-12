using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Items
{
    public abstract class AttackItem : Item
    {
        public Damage.Damage DamageDeal { get; private set; }
        public AttackItem(string name, string description, Damage.Damage damage) : base(name, description)
        {
            DamageDeal = damage;
        }
    }
}