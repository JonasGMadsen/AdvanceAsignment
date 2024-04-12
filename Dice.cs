using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AdvanceAsignment
{
    public class Dice
    {
        public int Sides { get; private set; }
        private Random random;

        public Dice(int sides)
        {
            if (sides <= 0)
            {
                throw new ArgumentException("Sides must be greater than 0");
            }
            Sides = sides;
            random = new Random();
        }

        public Damage Roll()
        {
            int rollValue = random.Next(1, Sides + 1);

            return new Damage(rollValue);
        }
    }
}
