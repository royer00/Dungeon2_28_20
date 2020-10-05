using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace DungeonExecutable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opening screen functionality
            Console.WriteLine(TitleScreen.ShowHeader());
            Console.WriteLine(TitleScreen.ShowOpeningContent());
            Console.Title = "The Castle";

            //Instantiating a base player that the user modifies via PlayerCreation()
            Player player = new Player("", 100, 10, 1000, 1000, 0, Race.Human, null, null, 1, null, null, null);
            player.PlayerCreation(player);

            //Instantiating game Bosses
            List<Monster> bosses = new List<Monster>();
            BossCombat.MakeBosses(bosses);

            //Instantiating and assigning a List of Monsters to call opponents from
            List<Monster> monsters = new List<Monster>();
            PopulateGame.PopulateMonsters(monsters);

            //Instantiating and assigning List of Items for monsters to carry randomly
            List<Item> monsterItems = new List<Item>();
            PopulateGame.PopulateItems(monsterItems);
            //initializing variable to keep track of monsters defeated
            int killcount = 0;

            //condition to exit game loop
            bool exit = false;
            //START OF MAIN GAME LOOP
            do
            {
                //Changing Title to display player stats
                TitleScreen.DisplayPlayerStatsInTitle(player);

                //Adding special weapons later as player levels up
                PopulateGame.AddSpecialWeapon(player, monsterItems);

                //Getting a random monster from List<>monsters
                Monster monster = Monster.GetRandomMonster(monsters);

                //Making sure monster doesn't have an item
                Monster.UnequipMonster(monster);

                //equip monster differently
                Monster.EquipMonster(monster, monsterItems);
                bool reloadRoom = false;
                do
                {
                    Combat.AlertPlayerOfMonster(monster);
                    ConsoleKey userChoice = Console.ReadKey().Key;
                    Console.Clear();
                    switch (userChoice)
                    {
                        //player chooses attack
                        case ConsoleKey.A:
                            Combat.DoBattle(player, monster);
                            if (monster.Life < 1)
                            {
                                Monster.MonsterIsDead(monster);
                                //if more than 20 items, inventory is full
                                if (player.Inventory.ShowNumberOfItems() >= 20)
                                {
                                    Player.PlayerInventoryIsFull();
                                    monster.RemoveMonsterItem(monster);
                                }
                                //if not transfer items
                                else
                                {
                                    monster.TransferItem(monster, player);
                                    monster.RemoveMonsterItem(monster);
                                }
                                //exit loop to get a new room and monster
                                reloadRoom = true;
                                killcount++;
                                //player assumes monsters XP
                                Player.AddMonsterXPToPlayer(player, monster);
                                Player.CheckLevel(player);
                                Player.PlayerLevelBonus(player);
                                //If the player reaches certain XP thresholds, the player fights a boss
                                BossCombat.CheckXPForBossBattle(player, bosses);
                                if (player.QuestItemsList.Count == 5)
                                {
                                    WinningScreen.YouveWon(player);
                                    reloadRoom = true;
                                    exit = true;
                                }
                            }
                            break;
                        //Run away and get another room and monster
                        case ConsoleKey.R:
                            //gives the monster a chance to attack as player runs away
                            Combat.PlayerRunAwayBattle(player, monster);
                            reloadRoom = true;
                            break;
                        //Display player stats
                        case ConsoleKey.P:
                            Console.WriteLine(player + "\nMonsters Slain: " + killcount);
                            break;
                        //Display monster stats
                        case ConsoleKey.M:
                            Console.WriteLine(monster);
                            break;
                        //leave game
                        case ConsoleKey.Escape:
                            Console.WriteLine("Goodbye brave warrior...");
                            exit = true;
                            break;
                        //use potion
                        case ConsoleKey.U:
                            //check to see if a potions is equipped before use
                            Player.CheckEquippedPotion(player);
                            break;
                        //View player inventory
                        case ConsoleKey.I:
                            player.Inventory.GetItem(player);
                            break;
                        default:
                            Console.WriteLine("You have made an error.  Please select again.");
                            break;
                    }
                    //player death
                    if (player.Life < 1)
                    {
                        Console.WriteLine("You have perished at the hands of the " + monster.Name + "!");
                        exit = true;
                    }
                } while (!reloadRoom && !exit);

            } while (!exit);

            Console.WriteLine("GAME OVER \n\nYou killed {0} monster{1}! ",
                killcount,
                killcount == 1 ? "" : "s");

        }//end main
    }//end class
}//end namespace
