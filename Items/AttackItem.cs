﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Items
{
    public abstract class AttackItem
    {
        public string Name { get; set; }
        public int Hit { get; set; }
        public int Range { get; set; }

        public AttackItem() { }
    }
}