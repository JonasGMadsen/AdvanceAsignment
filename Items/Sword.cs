using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Items
{
    /// <summary>
    ///  Sword class representing a specific type of AttackItem
    /// </summary>
    public class Sword : AttackItem
    {
        /// <summary>
        /// Constructer
        /// </summary>
        public Sword() : base("Sword", "A sharp bladed weapon", new Damage.Damage(5))
        {
        }
    }
}
