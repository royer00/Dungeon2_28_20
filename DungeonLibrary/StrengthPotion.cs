using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class StrengthPotion :  Potion
    {
        public int DamageIncrease { get; set; }
        public int NumOfSeconds { get; set; }

        public StrengthPotion(string name, string description, int damageIncrease, int numOfSeconds)
            : base(name, description)
        {
            DamageIncrease = damageIncrease;
            NumOfSeconds = numOfSeconds;
        }

        public override string ToString()
        {
            return string.Format($"{base.ToString()}\n Damge Increase: {DamageIncrease}\n Duration: {NumOfSeconds} seconds");
        }

        public override void UsePotion(Player player)
        {
            if (player.EquippedPotion == null)
            {
                Console.WriteLine("No equipped potion");
            }
            else
            {


                Console.WriteLine(player.EquippedPotion.Name + " has been used.");
                player.EquippedWeapon.MinDamage += DamageIncrease;//Increasing Min Damage
                player.EquippedWeapon.MaxDamage += DamageIncrease;//Increasing Max Damage
                                                                  //Creating variables to compare to limit duration
                DateTime limit = DateTime.Now;
                DateTime endTime = DateTime.Now.AddSeconds(NumOfSeconds);
                if (limit == endTime)
                {
                    //after seconds elapse, resetting max damage
                    player.EquippedWeapon.MaxDamage -= DamageIncrease;
                    player.EquippedWeapon.MinDamage -= DamageIncrease;
                }

               
            }
        }
    }
}
