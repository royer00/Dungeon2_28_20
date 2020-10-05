using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Inventory
    {


        List<Item> PlayerInventory = new List<Item>();




        //Add player item
        public void AddItem(Item item)
        {
            if (PlayerInventory.Count > 20)
            {
                Console.WriteLine("You have too many items.");
            }
            
           
            else
            {
                PlayerInventory.Add(item);
            }

        }
        //remove an item
        public void RemoveItem(Item item)
        {

            PlayerInventory.Remove(item);
        }
        //display number of items
        public int ShowNumberOfItems()
        {
           return PlayerInventory.Count;
        }

        public void GetItem(Player player)
        {
            Console.WriteLine("What kind of item are you looking for?\n" +
                "A)rmor\n" +
                "P)otions\n" +
                "W)eapons\n" +
                "Q)uest Items");
            ConsoleKey inventoryCat = Console.ReadKey(true).Key;
            switch (inventoryCat)
            {
                case ConsoleKey.A:
                    //create a list of armors
                    List<Item> armors = PlayerInventory.Where(x => x.Name.ToUpper().Contains("ARMOR")).ToList();
                    Console.WriteLine("You have {0} suit{1} of armor.",
                        armors.Count,
                        armors.Count == 1 ? "" : "s");
                    var repeat = false;
                    int i = 0;
                    do
                    {
                        Console.WriteLine(armors[i]);
                        Console.WriteLine(
                            "E)quip Item\n" +
                            "R)emove Item\n" +
                            "N)ext Item");
                        ConsoleKey answer = Console.ReadKey(true).Key;
                        if (answer == ConsoleKey.E)
                        {
                            Console.WriteLine(armors[i].Name + " has been equipped.");
                            player.EquippedArmor = (Armor)armors[i];
                            repeat = true;
                        }
                        else if (answer == ConsoleKey.R)
                        {//making sure there is an equipped armor
                            if (armors.Count == 1)
                            {
                                Console.WriteLine("You must wear something...");
                                repeat = true;
                                break;
                            }
                            if (armors[i] == player.EquippedArmor)
                            {//cannot get rid of equipped armor
                                Console.WriteLine("You cannot remove an equipped item.");
                                repeat = true;
                                break;
                            }
                            Console.WriteLine(armors[i].Name + " has been removed.");
                            RemoveItem(armors[i]);
                            repeat = true;
                        }
                        else if (answer == ConsoleKey.N)
                        {
                            //terminating at end of armor list
                            if (i >= armors.Count - 1)
                            {
                                Console.WriteLine("No more Armor.");
                                repeat = true;
                            }
                            else
                            {
                                i++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Selection.");
                            repeat = true;
                        }

                    } while (!repeat);
                    break;//end A 
                case ConsoleKey.P:
                    List<Item> potions = PlayerInventory.Where(x => x.Name.ToUpper().Contains("POTION")).ToList();
                    Console.WriteLine("You have {0} potion{1}.",
                        potions.Count,
                        potions.Count == 1 ? "" : "s");
                    if (potions.Count == 0)
                    {
                        break;
                    }
                    var again = false;
                    int j = 0;
                    do
                    {
                        Console.WriteLine(potions[j]);
                        Console.WriteLine(
                            "E)quip potion\n" +
                            "R)emove potion\n" +
                            "N)ext item");

                        ConsoleKey potionAnswer = Console.ReadKey(true).Key;
                        switch (potionAnswer)
                        {
                            case ConsoleKey.E:
                                Console.WriteLine(potions[j].Name + " has been equipped.");
                                player.EquippedPotion = (Potion)potions[j];
                                again = true;
                                break;
                            case ConsoleKey.R:
                                Console.WriteLine(potions[j].Name + " has been removed.");
                                RemoveItem(potions[j]);
                                again = true;
                                break;
                            case ConsoleKey.N:
                                //terminating at end of potions list
                                if (j >= potions.Count - 1)
                                {
                                    Console.WriteLine("No more Potions.");
                                    again = true;
                                }
                                else
                                {
                                    j++;
                                }
                                
                                break;
                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                    } while (!again);
                    break;//end P
                case ConsoleKey.W:
                    List<Item> weapons = PlayerInventory.Where(x => x.Name.ToUpper().Contains("WEAPON")).ToList();
                    Console.WriteLine("You have {0} weapon{1}.",
                        weapons.Count,
                        weapons.Count == 1 ? "" : "s"
                        );
                    if (weapons.Count == 0)
                    {
                        break;
                    }
                    var increase = false;
                    int k = 0;
                    do
                    {

                        Console.WriteLine(weapons[k]);
                        Console.WriteLine(
                            "E)quip Weapon\n" +
                            "R)emove Weapon\n" +
                            "N)ext Item");
                        ConsoleKey weapChoice = Console.ReadKey(true).Key;
                        switch (weapChoice)
                        {
                            case ConsoleKey.E:
                                player.EquippedWeapon = (Weapon)weapons[k];
                                increase = true;
                                break;
                            case ConsoleKey.R:
                                if (weapons.Count > 1)
                                {
                                    RemoveItem(weapons[k]);
                                    increase = true;
                                }
                                else
                                {//ensuring player has a weapon to do damage
                                    Console.WriteLine("You must have a weapon.");
                                    increase = true;
                                   
                                }
                                break;
                            case ConsoleKey.N:
                                //terminating at end of potions list
                                if (k >= weapons.Count - 1)
                                {
                                    Console.WriteLine("No more Weapons.");
                                    increase = true;
                                }
                                else
                                {
                                    k++;
                                }
                               
                                break;
                            default:
                                Console.WriteLine("Invalid Choice.");
                                break;
                        }
                    } while (!increase);
                    break;
                case ConsoleKey.Q:
                    if (player.QuestItemsList.Count == 0)
                    {
                        Console.WriteLine("You have no quest items.");
                    }
                    else
                    {
                        Console.WriteLine("Quest Items:\n");
                      foreach (var item in player.QuestItemsList)
                      {
                         Console.WriteLine("*********************\n" + item + "\n********************");
                      }
                    }
                    break;
                    
            }//end switch
        }//end GetItem()

       



    }//end class
}//end namespace
