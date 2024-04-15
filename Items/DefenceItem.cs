using AdvanceAsignment.Damage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Items
{
    /// <summary>
    /// Item the provides damage reduction
    /// </summary>
    public class DefenceItem : Item
    {
        // The damage reduction this item provides
        public DamageReduction DamageReduction { get; set; }
        /// <summary>
        /// Constructer
        /// </summary>
        /// <param name="name">Name of item</param>
        /// <param name="description">Description of item</param>
        /// <param name="damageReduction">The damage reduction this item provides</param>
        public DefenceItem(string name, string description, DamageReduction damageReduction) : base(name, description)
        {
            DamageReduction = damageReduction;
        }
    }
}
