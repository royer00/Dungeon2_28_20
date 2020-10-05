using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
      
        public List<QuestItems> QuestItemsList { get; set; }
        public Inventory Inventory { get; set; }
        private int _level;
        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public Potion EquippedPotion { get; set; }
        public Armor EquippedArmor { get; set; }
        public int Level
        {//max level is 10
            get { return _level; }
            set {
                _level = value < 10 ? value : 10;
                }
        }


        public Player(string name, int hitChance, int block, int maxLife, int life, int xp, Race characterRace, Weapon equippedWeapon, Potion equippedPotion, int level, Armor equippedArmor, Inventory inventory, List<QuestItems> questItemslist)
            :base(name, hitChance, block, maxLife, life, xp)
        {
            
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            EquippedPotion = equippedPotion;
            Level = Level;
            EquippedArmor = equippedArmor;
            Inventory = inventory;
            QuestItemsList = questItemslist;
           
        }

       

        public override string ToString()
        {
            string description = "";
            switch (CharacterRace)
            {
                case Race.Human:
                    description = "Good at everything";
                    break;
                case Race.Dwarf:
                    description = "Industrious and sturdy";
                    break;
                case Race.Giant:
                    description = "Massive and powerful, but oh so slow..";
                    break;
                case Race.Elf:
                    description = "Intelligent and fast";
                    break;
                case Race.Orc:
                    description = "Strong and good at many things, but vulnerable to fire and u - g - l - y";
                    break;
            }

            return string.Format("-+-+ {0} +-+-\nLife: {1} of {2}\nHit Chance: {3}%\nWeapon:------- \n{4}\n--------------\nBlock: {5}%\n{6}: {7}\nLevel: {8}\nArmor: {9}\nEquipped Potion: {10}",
                Name,
                Life,
                MaxLife,
                CalcHitChance(),
                EquippedWeapon,
                Block,
               CharacterRace,
                description,
                Level,
                EquippedArmor.Name,
                EquippedPotion == null ? "You have no potion": EquippedPotion.Name
                );
        }//end to string

      
        public override int CalcBlock()
        {//if the weapon is two handed, decreased the block by 10%
            if (EquippedWeapon.IsTwoHanded)
            {
                
                Block -= Block / 10;
                return Block;

            }
            else 
            {
                Block = Block + Block / 4;
                return Block;
            }
            
            
        }//end CalcBlock()

        //Calculate Player HitChance
        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }

        //Calculate amount of damage Player can deal
        public override int CalcDamage()
        {//if the equipped weapon is two handed, increase the minimum and maximum damage by 5%
            if (EquippedWeapon.IsTwoHanded)
            {
                EquippedWeapon.MinDamage += EquippedWeapon.MinDamage / 20;
                EquippedWeapon.MaxDamage += EquippedWeapon.MaxDamage / 20;
            }
            return new Random().Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
        }


        public static void CheckLevel(Player player)
        {
            if (player.XP >= 1000 && player.XP < 2000)
            {
                player.Level = 1;
             
            }
            else if (player.XP >= 2000 && player.XP < 3000)
            {
                player.Level = 2;
              

            }
            else if (player.XP >= 3000 && player.XP < 4000)
            {
                player.Level = 3;
               

            }
            else if (player.XP >= 4000 && player.XP < 5000)
            {
                player.Level = 4;
              

            }
            else if (player.XP >= 5000 && player.XP < 6000)
            {
                player.Level = 5;
               

            }
            else if (player.XP >= 6000 && player.XP < 7000)
            {
                player.Level = 6;
              

            }
            else if (player.XP >= 7000 && player.XP < 8000)
            {
                player.Level = 7;
            }
            else if (player.XP >= 8000 && player.XP < 9000)
            {
                player.Level = 8;
            }
            else if (player.XP >= 9000 && player.XP < 10000)
            {
                player.Level = 9;
            }
            else if (player.XP >= 10000)
            {
                player.Level = 10;
            }
            else
            {
                player.Level = player.Level;
            }
        }
        //Leveling System
        public static void PlayerLevelBonus(Player player)
        {
            //constant values to calculate level up percentages
            const int baseHitChance = 35;
            const int baseBlock = 10;
            const int baseMaxLife = 100;
            switch (player.Level)
            {
                case 1:
                    player.Block += baseBlock / 5;
                    player.HitChance += baseHitChance / 5;
                    player.MaxLife += baseMaxLife / 5;
                    break;
                case 2:
                    player.Block += baseBlock / 7;
                    player.HitChance += baseHitChance / 7;
                    player.MaxLife += baseMaxLife / 7;
                    break;
                case 3:
                    player.Block += baseBlock / 10;
                    player.HitChance += baseHitChance / 10;
                    player.MaxLife += baseMaxLife / 10;
                    break;
                case 4:
                    player.Block += baseBlock / 13;
                    player.HitChance += baseHitChance / 13;
                    player.MaxLife += baseMaxLife / 13;
                    break;
                case 5:
                    player.Block += baseBlock / 15;
                    player.HitChance += baseHitChance / 15;
                    player.MaxLife += baseMaxLife / 15;
                    break;
                case 6:
                    player.Block += baseBlock / 17;
                    player.HitChance += baseHitChance / 17;
                    player.MaxLife += baseMaxLife / 17;
                    break;
                case 7:
                    player.Block += baseBlock / 20;
                    player.HitChance += baseHitChance / 20;
                    player.MaxLife += baseMaxLife / 20;
                    break;
                case 8:
                    player.Block += baseBlock / 25;
                    player.HitChance += baseHitChance / 25;
                    player.MaxLife += baseMaxLife / 25;
                    break;
                case 9:
                    player.Block += baseBlock / 30;
                    player.HitChance += baseHitChance / 30;
                    player.MaxLife += baseMaxLife / 30;
                    break;
                case 10:
                    player.Block += baseBlock / 10;
                    player.HitChance += baseHitChance / 10;
                    player.MaxLife += baseMaxLife / 10;
                    break;
                default:
                    break;
            }
        }//end player level
        
        //Player Creation
        public void PlayerCreation(Player player)
        {
            Console.WriteLine("Enter your name, brave soul: ");
            player.Name = Console.ReadLine();
            Inventory playerInventory = new Inventory();//instantiating an inventory
            player.Inventory = playerInventory;
            Console.WriteLine("Choose a race:\n" +
                "H)uman - a race with the potential to be good at everything they try\n" +
                "E)lf - an ancient race, lighting quick but frail\n" +
                "O)rc - a smaller race, slightly weaker, but excellent at stealth\n" +
                "D)warf - a smaller race, but hearty and industrious\n" +
                "G)iant - an incredibly powerful and hearty race, but oh so slow..");
            ConsoleKey raceChoice = Console.ReadKey(true).Key;
            switch (raceChoice)
            {//player is given different starting weapon depending on race
             //player is given different advantages and disadvantages
                case ConsoleKey.H:
                    player.CharacterRace = Race.Human;                                      //vvvvvvvvvv vvvvvvvturned up for testing
                    Weapon longSword = new Weapon("Long Sword Weapon", "A long gleaming blade", 100, 5, true, 50);
                    player.Inventory.AddItem(longSword);
                    player.EquippedWeapon = longSword;
                    break;
                case ConsoleKey.E:
                    player.CharacterRace = Race.Elf;
                    player.HitChance += 5;
                    player.MaxLife -= 10;
                    Weapon shortSword = new Weapon("Short Sword Weapon", "A short, precise blade", 8, 3, false, 4);
                    player.Inventory.AddItem(shortSword);
                    player.EquippedWeapon = shortSword;
                    break;
                case ConsoleKey.O:
                    player.CharacterRace = Race.Orc;
                    player.MaxLife += 10;
                    player.HitChance -= 2;
                    Weapon mace = new Weapon("Mace Weapon", "A wicked-looking spiked club", 12, 0, true, 1);
                    player.Inventory.AddItem(mace);
                    player.EquippedWeapon = mace;
                    break;
                case ConsoleKey.D:
                    player.CharacterRace = Race.Dwarf;
                    player.HitChance -= 5;
                    Weapon broadAxe = new Weapon("Broad Axe Weapon", "A finely-honed, silver axe", 10, 0, true, 3);
                    player.Inventory.AddItem(broadAxe);
                    player.EquippedWeapon = broadAxe;
                    player.EquippedWeapon.MaxDamage += 3;
                    break;
                case ConsoleKey.G:
                    player.CharacterRace = Race.Giant;
                    Weapon warHammer = new Weapon("War Hammer Weapon", "A massive iron hammer", 15, -2, true, 4);
                    player.Inventory.AddItem(warHammer);
                    player.EquippedWeapon = warHammer;
                    player.EquippedWeapon.MaxDamage += 15;
                    player.HitChance -= 10;
                    player.MaxLife += 20;
                    player.Block -= 10;
                    break;
                default:
                    Console.WriteLine("If you can't choose well, you will be a human.");
                    break;
                    
            }//end race switch
           
            Armor clothArmor = new Armor("Cloth Armor", "Lightweigth, but little protection", 1);
            HealingPotion h1 = new HealingPotion("Healing Potion", "heals what ails you", 5);
            //starting player off with cloth armor and some healing potions
            player.EquippedArmor = clothArmor;
            player.EquippedPotion = h1;
            
            //separate inventory for quest items
            List<QuestItems> questItems = new List<QuestItems>();
            player.QuestItemsList = questItems;
            player.Inventory.AddItem(clothArmor);
            player.Inventory.AddItem(h1);
            
            Console.Clear();
            Console.WriteLine("----------------YOUR CHARACTER-----------\n");
            Console.WriteLine($"{player}\n");
            Console.WriteLine("________________________________________________________________");

            
        }//end PlayerCreation()
       
        public static void PlayerInventoryIsFull()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Inventory is full.  Remove items to add new ones.");
            Console.ResetColor();
        }

        public static void AddMonsterXPToPlayer(Player player, Monster monster)
        {
            player.XP += monster.XP;
        }

        public static void CheckEquippedPotion(Player player)
        {
            if (player.EquippedPotion != null)
            {
                player.EquippedPotion.UsePotion(player);
                player.Inventory.RemoveItem(player.EquippedPotion);
                player.EquippedPotion = null;
            }
            else
            {
                Console.WriteLine("You have not equipped a potion.");
            }
        }

       



    }//end class
}//endnamespace
