using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Dragon : Monster
    {
    
        public bool IsFlying { get; set; }
        

        public Dragon(string name, int hitChance, int block, int maxLife, int life, string description, int maxDamage, int minDamage, int xp, bool isArmored, Item monsterItem, bool isFlying)
            :base(name, hitChance, block, maxLife, life, description, maxDamage, minDamage, xp, isArmored, monsterItem)
        {
            IsFlying = isFlying;
        }

        //ctor with picture
        public Dragon(string name, int hitChance, int block, int maxLife, int life, string description, int maxDamage, int minDamage, int xp, bool isArmored, Item monsterItem, string monsterPic,QuestItems questItem, bool isFlying)
           : base(name, hitChance, block, maxLife, life, description, maxDamage, minDamage, xp, isArmored, monsterItem, monsterPic, questItem)
        {
            IsFlying = isFlying;
            
        }



        public override string ToString()
        {
            return base.ToString() + (IsFlying ? "\nIt's hovering just over the ground" : "\nIt crawls toward you on its clawed feet.");
        }

        public override int CalcBlock()
        {
            
            return IsFlying ? Block = Block / 2 : Block;
        }


    }//end class
}//end namespace
