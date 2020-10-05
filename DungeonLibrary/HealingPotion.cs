using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class HealingPotion : Potion
    {
        public int AmountToHeal { get; set; }

        public HealingPotion(string name, string description, int amountToHeal)
            : base(name, description)
        {
            Name = name;
            Description = description;
            AmountToHeal = amountToHeal;
        }

        public override string ToString()
        {
            return string.Format($"{base.ToString()}\nLife = +{AmountToHeal}");
        }

        public override void UsePotion(Player player)
        {
          
            Console.WriteLine(player.EquippedPotion.Name + " has been used.");
            player.Life += AmountToHeal;
           
        }

    }
}
