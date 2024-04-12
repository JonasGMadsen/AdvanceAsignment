using AdvanceAsignment.Damage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Items
{
    public class DefenceItem : Item
    {
        public DamageReduction DamageReduction { get; set; }
        public DefenceItem(string name, string description, DamageReduction damageReduction) : base(name, description)
        {
            DamageReduction = damageReduction;
        }
    }
}
