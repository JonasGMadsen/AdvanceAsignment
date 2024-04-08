using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Monsters
{
    public abstract class Monster : IMonster
    {
        public string Name { get; set; }
        public int Hitpoints { get; set; }
        public AttackItem AttackItem { get; set; }
        public DefenceItem DefenceItem { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Monster(string name, int hitPoints, int x, int y)
        {
            Name = name;
            Hitpoints = hitPoints;
            X = x;
            Y = y;
        }

        public void DoDamage(Monster enemy)
        {
            if (AttackItem != null)
            {
                int damage = AttackItem.Hit;
                enemy.ReceiveDamage(damage);
                Console.WriteLine($"{Name} attacked {enemy.Name} for {damage} damage");
            }
        }

        public void ReceiveDamage(int dmg)
        {
            if (DefenceItem != null)
            {
                dmg -= DefenceItem.ReduceHitpoints;
                dmg = Math.Max(dmg, 0); // Ensure damage doesn't go below 0
            }

            Hitpoints -= dmg;
            Console.WriteLine($"{Name} received {dmg} damage");

            if (Hitpoints <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            Console.WriteLine($"{Name} is dead");
        }

    }
}
