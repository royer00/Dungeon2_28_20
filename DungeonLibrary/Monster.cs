using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
       

        private int _minDamage;
        public QuestItems QuestItem { get; set; }
        public bool IsArmored { get; set; }
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public Item MonsterItem { get; set; }
        public string MonsterPic { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = value > 0 && value <= MaxDamage ? value : 1;
            }//end set
        }

        //FQCTOR
        public Monster(string name, int hitChance, int block, int maxLife, int life, string description,int xp, int maxDamage, int minDamage, bool isArmored, Item monsterItem)
            :base(name, hitChance, block, maxLife, life, xp)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
            XP = xp;
            IsArmored = isArmored;
            MonsterItem = monsterItem;
        }

        //CTOR with picture
        public Monster(string name, int hitChance, int block, int maxLife, int life, string description, int maxDamage, int minDamage, int xp, bool isArmored, Item monsterItem, string monsterPic, QuestItems questItem)
            : base(name, hitChance, block, maxLife, life, xp)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
            XP = xp;
            IsArmored = isArmored;
            MonsterItem = monsterItem;
            MonsterPic = monsterPic;
            QuestItem = questItem;
            
        }



        public override string ToString()
        {
            
            return string.Format("-------{0}------\n{1}\n{2}\n{3}",
                Name,
                Description,
                Life > MaxLife / 2 ?"The " + Name +
            " seems uninjured" : "The " + Name + " is badly damaged ",
                MonsterItem == null ? "" :"The " + Name + " is carrying a " + MonsterItem.Name + "."
                );
        }

        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }

        //If armored, increasing MaxLife
        public virtual int Armored(Monster monster)
        {
            if (IsArmored)
            {
                return MaxLife += MaxLife / 10;
            }
            else
            {
                return MaxLife;
            }
        }

        //Assigning a random item to a monster 
        public static void EquipMonster(Monster monster, List<Item> monsterItems)
        {
            
            int diceRoll = new Random().Next(1, 7);
            if (diceRoll > 4 && monster.MonsterItem == null)
            {
                monster.MonsterItem = monsterItems[new Random().Next(monsterItems.Count)];
            }
            else
            {
                monster.MonsterItem = null;
            }
        }
        //Transfering items from a defeated monster
        public void TransferItem(Monster monster, Player player)
        {
            bool repeat = false;
            do
            {
                if (monster.MonsterItem != null)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Do you wish to take the {0} from the monster? Y/N ", monster.MonsterItem.Name);
                    Console.ResetColor();
                    ConsoleKey takeItem = Console.ReadKey(true).Key;
                    switch (takeItem)
                    {
                        case ConsoleKey.Y:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("You have added a {0} to your inventory\n", monster.MonsterItem.Name);
                            Console.ResetColor();
                            player.Inventory.AddItem(monster.MonsterItem);
                            repeat = true;
                            break;
                        case ConsoleKey.N:
                            Console.WriteLine("This wretched item isn't worthy of you.\n");
                            repeat = true;
                            break;
                        default:
                            Console.WriteLine("Please make sure you answer the question...");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("This monster left you nothing\n");
                    repeat = true;
                }
            } while (!repeat);
        }

        public void RemoveMonsterItem(Monster monster)
        {
            monster.MonsterItem = null;
        }

        public static Monster GetRandomMonster(List<Monster> monsters)
        {
            Monster monster = monsters[new Random().Next(monsters.Count - 1)];
            return monster;
        }
        public static Monster UnequipMonster(Monster monster)
        {
            monster.MonsterItem = null;
            return monster;
        }

        public static void CheckMonsterLife(Monster monster)
        {
            if (monster.Life < 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You have vanquished the {0}!", monster.Name);
                Console.ResetColor();
            }
        }

        public static void MonsterIsDead(Monster monster)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You have vanquished the {0}!", monster.Name);
            Console.ResetColor();
        }
    }//end class
}//end namespace
