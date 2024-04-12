using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment
{
    public class DefenceItem : WorldObject
    {
        public string Name { get; set; }
        public int ReduceHitpoints { get; set; }

        public DefenceItem(string name, int xCordinate, int yCordinate, bool looteable, bool removeable, int reduceHitpoints) : base(name, xCordinate, yCordinate, looteable, removeable)
        {
            Name = name;
            ReduceHitpoints = reduceHitpoints;
        }

        

    }
}
