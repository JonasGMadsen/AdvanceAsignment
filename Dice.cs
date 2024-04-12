using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment
{
    public class Dice
    {
        public int Sides { get; set; }
        public int Value { get; set; }

        public Dice(int sides)
        {
            Sides = sides;
        }

        public void Roll()
        {
            Random rnd = new Random();
            Value = rnd.Next(1, Sides + 1);
        }
    }
}
