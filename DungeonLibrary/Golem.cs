using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Golem : Monster
    {

        public bool IsStone { get; set; }

        public Golem(string name, int hitChance, int block, int maxLife, int life, string description, int maxDamage, int minDamage, int xp, bool isArmored, Item monsterItem, bool isStone)
            :base(name, hitChance, block, maxLife, life, description, maxDamage, minDamage, xp, isArmored, monsterItem)
        {
            IsStone = isStone;
        }

        public Golem(string name, int hitChance, int block, int maxLife, int life, string description, int maxDamage, int minDamage, int xp, bool isArmored, Item monsterItem, bool isStone, string monsterPic, QuestItems questItem)
                  : base(name, hitChance, block, maxLife, life, description, maxDamage, minDamage, xp, isArmored, monsterItem, monsterPic, questItem)
        {
            IsStone = isStone;
        }




        public override string ToString()
        {
            return base.ToString() + (IsStone ? "This golem is made of a nearly inpenetrable stone!" : "This is a standard flesh golem");
        }
        public override int CalcBlock()
        {
            if (IsStone)
            {
                return Block += Block / 20;
            }
            else
            {
                return Block;
            }
        }//end CalcBlock()

        public override int CalcDamage()
        {
            return base.CalcDamage() + 5;
        }

    }
}
