using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvanceAsignment.Items;

namespace AdvanceAsignment.Monsters
{
    public abstract class Monster : WorldObject
    {
        public Position Position { get; set; }

        public double HitPoints { get; set; }

        public string Name { get; set; }

        public Random DamageGenerator = new Random();

        public bool IsDead
        {
            get { return HitPoints <= 0; }
        }

        public Monster(Position position, double hitPoints, string name)
        {
            hitPoints = hitPoints;
            Name = name;
            //Måske noget logging
        }

        public abstract Damage.Damage TakeDamage(Damage.Damage taken);

        public abstract Damage.Damage GiveDamage();

    }
}
