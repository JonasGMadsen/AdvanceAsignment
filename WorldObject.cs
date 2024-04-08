using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment
{
    public class WorldObject
    {
        public string Name { get; set; }
        public bool Lootable { get; set; }
        public bool Removeable { get; set; }

        public WorldObject() { }
    }
}
