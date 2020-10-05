using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class PopulateGame
    {
        public static List<Item> PopulateItems(List<Item> gameItems)
        {
            Weapon rustySword = new Weapon("Rusty Sword Weapon", "a rusty sword", 5, 0, false, 1);
            HealingPotion h1 = new HealingPotion("Healing Potion", "heals what ails you", 5);
            StrengthPotion s1 = new StrengthPotion("Strength Potion", "gives you enhanced strength for a brief period", 5, 60);
            HealingPotion h2 = new HealingPotion("Advanced Healing Potion", "A fortifying elixir that restores much of your life", 20);
            StrengthPotion s2 = new StrengthPotion("Advanced Strength Potion", "A hearty elixir that sereiously bolsters your strength", 10, 120);
            Armor a1 = new Armor("Chain Mail Armor", "A sturdy mail shirt with good protection", 5);
            Armor a2 = new Armor("Plate Mail Armor", "A gleaming suit of armor", 10);
            Weapon w1 = new Weapon("Sword of Light Weapon", "The finest crafted sword in the land", 35, 5, true, 5);
            Weapon w2 = new Weapon("Caveman Club Weapon", "A primal, savage oak club that seems oddly well-balanced", 40, 2, true, 5);
            Weapon w3 = new Weapon("Hammer of Justice Weapon", "A superbly crafted hammer", 50, 0, true, 5);
            List<Item> stuff = new List<Item> { rustySword, a1, a2, w1, w2, w3, h1, h1, h1, h1, h1, h1, s1, s1, s1, s1, s1, s1, s2, s2, s2, h2, h2, h2 };
            for (int i = 0; i < stuff.Count; i++)
            {
                gameItems.Add(stuff[i]);
            }
            return gameItems;
        }

        public static List<Monster> PopulateMonsters(List<Monster> monsterlist)
        {
            Monster m4 = new Monster("Dark Elf", 40, 30, 65, 65, "A grotesque reflection of a normal elf...", 70, 18, 5, true, null);
            Monster m3 = new Monster("Troll", 30, 30, 30, 30, "A giant, foul beast with a taste for man-flesh", 50, 20, 3, true, null);
            Monster m2 = new Monster("Mummy", 35, 20, 20, 20, "A horrific, foul-smelling corpse, still clad in decaying bandages.", 10, 10, 0, false, null);
            Monster m1 = new Monster("Zombie", 50, 10, 15, 15, "a ghoulish, rotting corpse", 400, 3, 0, true, null);
            Dragon d1 = new Dragon("Young Black Dragon", 60, 20, 30, 20, "A young, gleaming black dragon", 10, 3, 10, false, null, false);
            Dragon d2 = new Dragon("Young Green Dragon", 60, 20, 30, 20, "A young, gleaming black dragon", 10, 3, 13, true, null, null, null, true);
            List<Monster> monsters = new List<Monster> { m1, m1, m1, m1, m1, m2, m2, m2, m3, d1, d1, d1, d1, d2, d2, d2, d2, m4 };
            for (int i = 0; i < monsters.Count; i++)
            {
                monsterlist.Add(monsters[i]);
            }
            return monsterlist;
            

        }

        public static void AddSpecialWeapon(Player player, List<Item> monsterItems)
        {
            //Special Weapons to add to monsterItems as the player levels up
            Weapon w1 = new Weapon("Sword of Light Weapon", "The finest crafted sword in the land", 35, 5, true, 5);
            Weapon w2 = new Weapon("Caveman Club Weapon", "A primal, savage oak club that seems oddly well-balanced", 40, 2, true, 5);
            Weapon w3 = new Weapon("Hammer of Justice Weapon", "A superbly crafted hammer", 50, 0, true, 5);

            //checking level to and adding specified item
            switch (player.Level)
            {
                case 5:
                    monsterItems.Add(w1);
                    break;
                case 7:
                    monsterItems.Add(w2);
                    break;
                case 9:
                    monsterItems.Add(w3);
                    break;
                default:
                    break;
            }

        }

        

    }
}
