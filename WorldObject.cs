using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment
{
    public class WorldObject : World
    {
        public string Name { get; set; }
        public bool Lootable { get; set; }
        public bool Removeable { get; set; }

        public WorldObject(string name, int xCordinate, int yCordinate, bool looteable, bool removeable) : base(xCordinate, xCordinate)
        {
            Name = name;
            Lootable = looteable;
            Removeable = removeable;
            
        }
    }
}
