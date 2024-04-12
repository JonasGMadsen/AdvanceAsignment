using AdvanceAsignment.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.Protagonist
{
    public class Protagonist
    {
        public string Name { get; set; }

        public int HitPoints { get; set; }

        public AttackItem EquippedAttackItem { get; private set; }

        public DefenceItem EquippedDefenceItem { get; private set; }

        public void EquipAttackItem(AttackItem item)
        {

            EquippedAttackItem = item;
        }

        public void EquipDefenceItem(DefenceItem item)
        {
            EquippedDefenceItem = item;
        }

        public bool IsDead
        {
            get { return HitPoints <= 0; }
        }
    }
}
