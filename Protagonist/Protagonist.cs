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
    /// <summary>
    /// The Protgonist AKA the player
    /// </summary>
    public class Protagonist
    {
        //Protagonist name
        public string Name { get; set; }
        
        //Hitpoints
        public double HitPoints { get; set; }

        //Position in world
        public Position Position { get; set; }

        //Used to generate damage
        public Random DamageGenerator = new Random();

        //The attack item the player is wielding
        public AttackItem WieldedAttackItem { get; set; }

        //The defence item the player is wielding
        public DefenceItem WornDefenceItem { get; set; }
        //Player state
        public IStateMachine State { get; private set; }


        //True if hitpoints is bellow 0
        public bool IsDead
        {
            get { return HitPoints <= 0; }
        }
        /// <summary>
        /// Constructer
        /// </summary>
        /// <param name="name">Protagonist name</param>
        /// <param name="hitPoints">Hitpoints of protagonist</param>
        public Protagonist(string name, int hitPoints = 100)
        {
            Name = name;
            HitPoints = hitPoints;
            Position = new Position(0, 0);
            //remember to implment something the checks if the protag is poisned
            State = new NormalState();
        }

        /// <summary>
        /// Used to move the protagonist to a new position in the world
        /// </summary>
        /// <param name="position">The new position</param>
        /// <returns>True if the position is in the world and false is it is not</returns>
        public bool ProtagMovePosition(Position position)
        {
            if (World.Instance.IsInsideWorld(position))
            {
                Position = position;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Calculates the damage the protagonist takes
        /// </summary>
        /// <param name="taken">The damage taken</param>
        /// <returns>The damage taken</returns>
        public Damage.Damage CalculateTakeDamage(Damage.Damage taken) //To future me. Don't call namespaces the same thing as the class in the namespace, so I don't have to call Damage.Damage fx xD
        {
            Damage.Damage dmgToTake = State.CalculateTakeDamage(taken, WornDefenceItem);
            HitPoints -= dmgToTake.DamageNumber;
            return dmgToTake;
        }

        /// <summary>
        /// Called when protagonist is weakened
        /// </summary>
        public void WeakenedPlayer()
        {
            State = new WeakednedState();
        }
        /// <summary>
        /// Called when protagonist recovers
        /// </summary>
        public void PlayerRecovered()
        {
            State = new NormalState();
        }

        /// <summary>
        /// Equips an offensive item
        /// </summary>
        /// <param name="item"></param>
        public void EquipOffensive(AttackItem item)
        {
            WieldedAttackItem = item;
        }

        /// <summary>
        /// Calcaulates the damage the protagonist deals
        /// </summary>
        /// <returns>The damage the protagonist deals. If the protagonist has nothing equiped. He/she deals 1 damage</returns>
        public Damage.Damage CalculateGiveDamage()
        {
            if (State == null)
            {
                Console.WriteLine("State is not initialized.");
            }
            if (WieldedAttackItem == null)
            {
                Console.WriteLine("No weapon equipped.");
                return new Damage.Damage(1);   //To future me. Don't call namespaces the same thing as the class in the namespace, so I don't have to call Damage.Damage fx xD
            }

            return State.CalculateGiveDamage(
                new Damage.Damage(DamageGenerator.Next(2, 10)), //To future me. Don't call namespaces the same thing as the class in the namespace, so I don't have to call Damage.Damage fx xD
                WieldedAttackItem);
        }



    }
}
