using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Items
{
    /// <summary>
    /// Base class for all items
    /// </summary>
    public class Item
    {
        //Name of item
        public string Name { get; protected set; }
        //Description of item
        public string Description { get; protected set; }

        /// <summary>
        /// constructer
        /// </summary>
        /// <param name="name">Name of item</param>
        /// <param name="description">Description of item</param>
        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
