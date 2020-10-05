using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Minotaur: Monster
    {

        public Minotaur(string name, int hitChance, int block, int maxLife, int life, string description, int maxDamage, int minDamage, int xp, bool isArmored, Item monsterItem, string monsterPic, QuestItems questItem)
          : base(name, hitChance, block, maxLife, life, description, maxDamage, minDamage, xp, isArmored, monsterItem, monsterPic, questItem)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
