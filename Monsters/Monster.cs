using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvanceAsignment.Items;

namespace AdvanceAsignment.Monsters
{

    /// <summary>
    /// Monster class that all kinds of monsters should inherit from
    /// </summary>
    public abstract class Monster : WorldObject
    {
        //Position in world
        public Position Position { get; set; }

        //Monster hitpoints
        public double HitPoints { get; set; }

        //Name of monster
        public string Name { get; set; }

        //Used to generate random damage for the inheriting monster.
        public Random DamageGenerator = new Random();
        
        //Used to check if the creature is dead
        public bool IsDead
        {
            get { return HitPoints <= 0; }
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="position">Position in world</param>
        /// <param name="hitPoints">Monster hitpoints</param>
        /// <param name="name">Name of monster</param>
        public Monster(Position position, double hitPoints, string name)
        {
            Position = position;
            HitPoints = hitPoints;
            Name = name;
            //Måske noget logging
        }

        /// <summary>
        /// Calculates damage taken for the creature
        /// </summary>
        /// <param name="taken">Damage the creature takes</param>
        /// <returns></returns>
        public abstract Damage.Damage TakeDamage(Damage.Damage taken);

        /// <summary>
        /// Calculates the damage the creature gives
        /// </summary>
        /// <returns>The amount of damage given</returns>
        public abstract Damage.Damage GiveDamage();

    }
}
