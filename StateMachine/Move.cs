using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.StateMachine
{
    public class Move
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Move() { }
    }
}