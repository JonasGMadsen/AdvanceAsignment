using AdvanceAsignment.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvanceAsignment;
using AdvanceAsignment.Damage;
using AdvanceAsignment.Protagonist.States;

namespace AdvanceAsignment.Protagonist
{
    public class Protagonist
    {
        public string Name { get; set; }

        public double HitPoints { get; set; }

        public Position Position { get; set; }

        public Random DamageGenerator = new Random();

        public AttackItem WieldedAttackItem { get; set; }

        public DefenceItem WornDefenceItem { get; set; }
        public IStateMachine State { get; private set; }



        public bool IsDead
        {
            get { return HitPoints <= 0; }
        }

        public Protagonist(string name, int hitPoints = 100)
        {
            Name = name;
            HitPoints = hitPoints;
            Position = new Position(0, 0);
            State = new NormalState();
        }

        public bool ProtagMovePosition(Position position)
        {
            if (World.Instance.IsInsideWorld(position))
            {
                Position = position;
                return true;
            }
            return false;
        }

        public Damage.Damage CalculateTakeDamage(Damage.Damage taken)
        {
            Damage.Damage dmgToTake = State.CalculateTakeDamage(taken, WornDefenceItem);
            HitPoints -= dmgToTake.DamageNumber;
            return dmgToTake;
        }

        public void WeakenedPlayer()
        {
            State = new WeakednedState();
        }

        public void PlayerRecovered()
        {
            State = new NormalState();


        }

        public void EquipOffensive(AttackItem item)
        {
            WieldedAttackItem = item;
        }

        public Damage.Damage CalculateGiveDamage()
        {
            if (State == null)
            {
                Console.WriteLine("State is not initialized.");
            }
            if (WieldedAttackItem == null)
            {
                Console.WriteLine("No weapon equipped.");
                return new Damage.Damage(1);  // Return no damage
            }

            return State.CalculateGiveDamage(
                new Damage.Damage(DamageGenerator.Next(2, 10)),
                WieldedAttackItem);
        }



    }
}
