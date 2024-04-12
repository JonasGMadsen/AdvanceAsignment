using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvanceAsignment.Items;

namespace AdvanceAsignment.Monsters
{
    public abstract class Monster : IMonster
    {
        public event EventHandler<string> OnAction; //Will prop be changed

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
            if (AttackItem != null && AttackItem.IsInRange(X, Y, enemy.X, enemy.Y))
            {
                int damage = AttackItem.Hit;
                enemy.ReceiveDamage(damage);
                OnAction?.Invoke(this, $"{Name} attacked {enemy.Name} for {damage} damage");
            }
        }

        public void ReceiveDamage(int damage)
        {
            int originalDamage = damage;

            if (DefenceItem != null)
            {
                damage -= DefenceItem.ReduceHitpoints;
                damage = Math.Max(damage, 0);
                OnAction?.Invoke(this, $"{Name}'s {DefenceItem.Name} reduced the damage from {originalDamage} to {damage}.");
            }

            Hitpoints -= damage;
            OnAction?.Invoke(this, $"{Name} received {damage} damage");

            if (Hitpoints <= 0)
            {
                Die();
            }
        }

        public void Die()
        {

        }

    }
}
