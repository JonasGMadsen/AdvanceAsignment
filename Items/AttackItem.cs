using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvanceAsignment.Damage;
using AdvanceAsignment.Items;


namespace AdvanceAsignment.Items
{
    /// <summary>
    /// Represents item that can inflict damage
    /// </summary>
    public abstract class AttackItem : Item
    {
        //The damage the item can deal
        public Damage.Damage DamageDeal { get; private set; }

        /// <summary>
        /// Constructer 
        /// </summary>
        /// <param name="name">Name of item</param>
        /// <param name="description">Description of item</param>
        /// <param name="damage">The damage the item can deal</param>
        public AttackItem(string name, string description, Damage.Damage damage) : base(name, description)
        {
            DamageDeal = damage;
        }
    }
}