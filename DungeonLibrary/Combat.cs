using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        public static void AlertPlayerOfMonster(Monster monster)
        {
            Console.WriteLine(Room.RoomDescription() + "\n" +
                 "In this room you see a " + monster.Name + "\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{monster.Name} is your opponent.");
            Console.ResetColor();
            Console.WriteLine(
                "\nChoose an action:\n" +
                "A)ttack\n" +
                "R)un Away\n" +
                "P)layer Stats\n" +
                "M)onster Stats\n" +
                "U)se Potion\n" +
                "I)nventory\n" +
                "(Esc to exit game)");
        }


        public static void DoAttack(Character attacker, Character defender)
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(50);
            if (diceRoll <= attacker.CalcHitChance() - defender.CalcBlock())
            {
                int damageDealt = attacker.CalcDamage();

                defender.Life -= damageDealt;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!",
                    attacker.Name,
                    defender.Name,
                    damageDealt);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("{0} missed!", attacker.Name);
            }
        }//end DoAttack()

        public static void DoBattle(Player player, Monster monster)
        {
            DoAttack(player, monster);
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
                if (player.Life < player.Life/4)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"You have {player.Life} life left. ");
                }
                Console.Title = $"Life: {player.Life} of {player.MaxLife} ||  XP: {player.XP} || Level {player.Level} || Items in Inventory {player.Inventory.ShowNumberOfItems()}";
               
            }
        }//end DoBattle()

        public static void PlayerRunAwayBattle(Player player, Monster monster)
        {
            Console.WriteLine("The " + monster.Name + " attacks you as you flee!");
            DoAttack(monster, player);
        }

    }//end class
}//end namespace
