using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class BossCombat
    {
        public static List<Monster> MakeBosses(List<Monster> bosses)
        {
            //Instantiating Quest Items you need to win the game
            #region QuestItems
            QuestItems goldenRing = new QuestItems("Golden Ring", "A plain, golden ring", 1);
            QuestItems silverStein = new QuestItems("Silver Stein", "A magnificent drinking vessel", 2);
            QuestItems blacksmithHammer = new QuestItems("Blacksmith's Hammer", "An old, well-worn smithing hammer", 3);
            QuestItems townCrest = new QuestItems("Town Crest", "a banner displaying the crest of the town", 4);
            QuestItems daughter = new QuestItems("The Mayor's Daughter", "A beautiful young woman", 5);
            #endregion
            //Instantiating Boss Monsters
            #region Vampire Boss
            Vampire v1 = new Vampire("Vampire", 60, 30, 300, 300, "A half-bat-half-man with glistening fangs.",500, 40, 10, false, null, @"
      _.-.
                                 ._.-.\
                    .^         _.-'=. \\
                  .'  )    .-._.-=-..' \'.
               .'   .'   _.--._-='.'   |  `.  ^.
             .'   .'    _`.-.`=-./'.-. / .-.\ `. `.
           .'    /      _.-=-=-/ | '._)`(_.'|   \  `.
          /    /|       _.--=.'  `. (.-v-.)/    |\   \
        .'    / \       _.-.' \-.' `-..-..'     / \   `.
       /     /   `-.._ .-.'      `.'   . _..-'  |    |
      '      |    |   /   )        \  /   \   \    \    `.
     /      /    /   /   /\                \   \   |      \
    /      /    /  .'  .'\ `.        .'     \   |   \      \
   /      /    /  /   /   \  `- -' .`.    .  \    \     |
  |      /    / .''\.'    | `.      .'   `.   \  |    |    |
 .'     /    / /   |      |      .' /       `.- `./    /    |
 |     /    .-|   / --.    / `.    | _.- ''\   |     |    \
.'    /  .-' |  /    `-.|       .'\_.'      `. |`.   |    |
|    |.- '     / /       /           \          \ \ `. \     \
|    /       /  |      /             \         |  `. `.|    |
|   |       /   `.     |      `   .'  \        /    \  \    /
|   |      ///.-'.\    |       \ /    `\      / /-.  \ |    |
|   /      \\\\    `    \.-     |    `-.\     |/   \\\\'.   |
 \ |        \\\|        |      / \      |          //// |  /
 | | '''        |     /   \     |          |//  |  \
 \ |                    |.-  |     \  .-| '' |  /
  \|                    /    |    / ` ../               / /
                        | '   /    |    /               | /
                        \.'  |    | `./                |/
                        /    \   /    \
                        \ `. /   \    /
                         |  | '. '
                         /  |      |  \
                        /   |      /   `.
                       | | | \   .'  `.. \
                      / / / ._`. \.'-. \`/
             LGB |/ / /  `'  `  |/|/
                       \|\|
", daughter);
            #endregion

            #region Minotaur
            Minotaur mt1 = new Minotaur("Minotaur", 50, 50, 200, 200, "A hulking beast with the body of a giant and the head of a bull", 50, 20, 500, false, null, @"
 .      .
                            |\____/|
                           (\|----|/)
                            \ 0  0 /
                             |    |
                          ___/\../\____
                         /     --       \
                        /  \         /   \
                       |    \___/___/(   |
                       \   /|  }{   | \  )
                        \  ||__}{__|  |  |
                         \  |;;;;;;;\  \ / \_______
                          \ /;;;;;;;;| [,,[|======'
                            |;;;;;;/ |     /
                            ||;;|\   |
                       snd  ||;;/|   /
                            \_|:||__|
                             \ ;||  /
                             |= || =|
                             |= /\ =|
                             /_/  \_\
", blacksmithHammer);

            #endregion

            #region TrollKing

            TrollKing t1 = new TrollKing("Troll King", 80, 50, 150, 150, "A towering, disgusting troll with the biggest axe you've ever seen!", 30, 500, 5, true, null, @"

█████████████████████████████
█████████████▒▒▒▒▒▒▒▒▒█████████████
█████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█████████
███████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒███████
██████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██████
█████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█████
█████▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█████
████▒▒▒▒███▒▒▒▒▒▒▒▒▒▒▒▒▒███▒▒▒▒████
███▒▒▒▒██████▒▒▒▒▒▒▒▒▒██████▒▒▒▒███
███▒▒▒███▐▀███▒▒▒▒▒▒▒███▀▌███▒▒▒███
███▒▒▒██▄▐▌▄███▒▒▒▒▒███▄▐▌▄██▒▒▒███
███▒▒▒▒██▌███▒▒▒█▒█▒▒▒███▐██▒▒▒▒███
██▒▒▒▒▒▒███▒▒▒▒██▒██▒▒▒▒███▒▒▒▒▒▒██
█▒▒▒▒▒▒▒▒█▒▒▒▒██▒▒▒██▒▒▒▒█▒▒▒▒▒▒▒▒█
█▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒█
█▒▒▒▒█▒▒█▒▒▒▒██▒▒▒▒▒██▒▒▒▒█▒▒█▒▒▒▒█
██▒▒▒█▒▒█▒▒▒▒█▒██▒██▒█▒▒▒▒█▒▒█▒▒▒██
███▒█▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒█▒███
█████▒▒█▒▒▒▐███████████▌▒▒▒█▒▒█████
███████▒▒▒▐█▀██▀███▀██▀█▌▒▒▒███████
███████▒▒▒▒█▐██▐███▌██▌█▒▒▒▒███████
███████▒▒▒▒▒▐▒▒▐▒▒▒▌▒▒▌▒▒▒▒▒███████
████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████
████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████
█████████▒▒█▒█▒▒▒█▒▒▒█▒█▒▒█████████
█████████▒██▒█▒▒▒█▒▒▒█▒██▒█████████
██████████████▒▒███▒▒██████████████
██████████████▒█████▒██████████████
████████████████████████████████
", townCrest);

            #endregion

            #region Golem
            Golem g1 = new Golem("Giant Golem", 50, 30, 150, 150, "A powerful, animated sculpture", 25, 10, 500, false, null, true, @"
  ___
         / ,_\    _____
        /  _)/   /o    \
        |  \    /_ `    \__________
        |   \____ >__,_  \         |
        |                  ____,   |
        \,___________     |    \   |
                   \      (     \  |__
                    \    \ \     \   _)_
           __________\/     \     \____/
          |                ) \
          |     _________ ,   |
          |    /       |      /
          |   /        |     /
          |  /_        |    /           
          |    )       |    \         
          \   /        |    /           
          |  /         |   /            
          /_/          |  (_            
                       |    )      
                       \   /       
                       |  /         
                  ____ /_/_____     
", silverStein);
            #endregion

            #region AncientRedDragon
            Dragon d3 = new Dragon("Ancient Red Dragon", 70, 45, 100, 20, "A giant, powerful Red Dragon", 25, 8, 500, true, null,
               @"
            ___, ____--'
                         _,-.'_,-'      (
                      ,-' _.-''....____(
            ,))_     /  ,'\ `'-.     (          /\
    __ ,+..a`  \(_   ) /   \    `'-..(         /  \
    )`-;...,_   \(_ ) /     \  ('''    ;'^^`\ <./\.>
        ,_   )   |( )/   ,./^``_..._  < /^^\ \_.))
       `=;; (    (/_')-- -'^^`      ^^-.`_.-` >-'
       `=\\ (                             _,./
         ,\`(                         )^^^
           ``;         __-'^^\       /
             / _>emj^^^   `\..`-.    ``'.
            / /               / /``'`; /
           / /          ,-=='-`=-'  / /
     ,-=='-`=-.               ,-=='-`=-.
   *******************************************
"
               , goldenRing, true);
            #endregion

            List<Monster> bigMonsters = new List<Monster> { d3, g1, t1, mt1, v1 };
            for (int i = 0; i < bigMonsters.Count; i++)
            {
                bosses.Add(bigMonsters[i]);
            }
            return bosses;


        }//end BossScene()

        public static void BossBattle(Player player, Monster monster)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The {monster.Name.ToUpper()} has appeared. There is no fleeing this battle.");
            Console.ResetColor();
            if (monster.Name.ToUpper() == "VAMPIRE")
            {
                Console.WriteLine("The Prince Of Darkness is here.  The source of all evil.  An involuntary shudder courses down your spine.  The princess appears behind him.  She is in some sort of trance.  This is the fight of your life!");
            }
            do
            {
                Console.WriteLine(monster.MonsterPic);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(monster.Name + " Life: " + monster.Life);
                Console.ResetColor();
                Console.WriteLine("Choose an Action:\n" +
                    "A)ttack\n" +
                    "U)se Potion\n" +
                    "I)nventory\n" +
                    "P)layer Stats\n" +
                    "M)onster Stats\n");
                ConsoleKey userChoice = Console.ReadKey().Key;
                Console.Clear();
                switch (userChoice)
                {
                    case ConsoleKey.A:
                        Combat.DoBattle(player, monster);
                        break;
                    case ConsoleKey.M:
                        Console.WriteLine(monster.Name);
                        Console.WriteLine(monster.Life);
                        Console.WriteLine(monster.XP);
                        break;
                    case ConsoleKey.I:
                        player.Inventory.GetItem(player);
                        break;
                    case ConsoleKey.P:
                        Console.WriteLine(player);
                        break;
                    case ConsoleKey.U:
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

                        break;
                    default:
                        break;
                }



            } while (player.Life > 0 && monster.Life > 0);

            if (monster.Life <= 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"You have defeated the {monster.Name}");
                Console.ResetColor();
                player.XP = player.XP + monster.XP;
                player.QuestItemsList.Add(monster.QuestItem);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"You have acquired the {monster.QuestItem.Name.ToUpper()}!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("You have expired");
            }



        }//end boss


        public static void CheckXPForBossBattle(Player player, List<Monster> bosses)
        {

            if (player.XP >= 2000 && player.XP < 2500)
            {
                //method for fighting boss
               BossBattle(player, bosses.Find(item => item.Name == "Ancient Red Dragon"));

            }
            else if (player.XP >= 4000 && player.XP < 4500)
            {
             BossBattle(player, bosses.Find(item => item.Name == "Giant Golem"));

            }
            else if (player.XP >= 6000 && player.XP < 6500)
            {
               BossBattle(player, bosses.Find(item => item.Name == "Troll King"));
            }
            else if (player.XP >= 8000 && player.XP < 8500)
            {
                BossBattle(player, bosses.Find(item => item.Name == "Minotaur"));
            }
            else if (player.XP >= 10000)
            {
              BossBattle(player, bosses.Find(item => item.Name == "Vampire"));
            }
           

        }
    }
}
