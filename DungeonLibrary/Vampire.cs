using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Vampire : Monster
    {
        public Vampire(string name, int hitChance, int block, int maxLife, int life, string description, int xp, int maxDamage, int minDamage, bool isArmored, Item monsterItem, string monsterPic, QuestItems questItem)
          : base(name, hitChance, block, maxLife, life, description, xp, maxDamage, minDamage, isArmored, monsterItem, monsterPic, questItem)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
