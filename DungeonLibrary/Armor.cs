using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Armor : Item
    {
        public int AdditionalBlockChance { get; set; }
       

        public Armor(string name, string description, int additionalBlockChance)
            :base(name, description)
        {
            AdditionalBlockChance = additionalBlockChance;
            
            

        }

        public override string ToString()
        {
            return string.Format($"{base.ToString()}\nAdditional Chance to Block:{AdditionalBlockChance}");
        }

        public void CalcBlockWithArmor(Player player)
        {
            player.Block += AdditionalBlockChance;

        }
       

    }
}
