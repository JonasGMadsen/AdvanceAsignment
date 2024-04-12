using AdvanceAsignment.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Protagonist
{
    public class Protagonist
    {
        public string Name { get; set; }

        public int HitPoints { get; set; }

        public Position Position { get; set; }

        public Random DamageGenerator = new Random();


        public bool IsDead
        {
            get { return HitPoints <= 0; }
        }

        public Protagonist(string name, int hitPoints = 100)
        {
            Name = name;
            HitPoints = hitPoints;
            Position = new Position(0, 0);
        }

      //  public Damage.Damage CalculateTakeDamage(Damage.Damage taken)
      //  {
      //      Lav metode + logic
      //  }

        //En metioder til items.
    }

}
