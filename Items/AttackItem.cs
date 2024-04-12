using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Items
{
    public abstract class AttackItem : WorldObject
    {
        public string Name { get; set; }
        public int Hit { get; set; }
        public int Range { get; set; }

        public AttackItem(string name, int xCordinate, int yCordinate, bool looteable, bool removeable, int hit, int range) : base(name, xCordinate, yCordinate, looteable, removeable) 
        {
            Name = name;
            Hit = hit;
            Range = range;
        }

        public bool IsInRange(int originX, int originY, int targetX, int targetY)
        {
            return Math.Sqrt((targetX - originX) * (targetX - originX) + (targetY - originY) * (targetY - originY)) <= Range;
        }
    }
}