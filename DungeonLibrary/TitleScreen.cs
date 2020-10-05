using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class TitleScreen
    {
        public static string ShowHeader()
        {
            string header = @"
***********************************************************************************
                   ___ _  _  __    __ __  __ ___ _   __
                    |  |__| |_    |  |__||__  |  |  |_
                    |  |  | |__   |__|  | __| |  |__|__
***********************************************************************************
                        ";
            return header;

        }

        public static string ShowOpeningContent()
        {
            string openingContent = 
        
               
        
                "The Castle is a C# Console Application Role-Playing Game." +
                "In the game, you will enter a series of rooms, fight various " +
                "monsters, and collect treasures. The object is to collect 5 quest treasures. This game is best viewed by making the console\n window full-screen.  Have fun!"+ "\n___________________________________________________________________________________________________________\n\n" +
      
                "You find yourself staring at massive, rusted portcullis." +
                "  The tunnel it hovers over projects a foul, rancid\n air. " +
                " You remember promising the villagers that you would " +
                "get their artifacts back.  \"This shouldn't be much " +
                "of a task for the likes of you!\"\n the Mayor had said. " +
                " \"We only need 5 things back: " +
                " A golden ring, a silver stein, the town crest, " +
                "the blacksmith's hammer, oh.....and my daughter.\" " +
                "he said with an oddly detached manner.  You could\n hardly " +
                "refuse finding a man's daughter.  The village was poor, " +
                "but it had treated you well.  You remember their\n faces as " +
                "you stare into the darkness.  With a silent prayer to\n any " +
                "god that might be listening, you step forward into the void..... ";

            return openingContent;
        }

        public static void DisplayPlayerStatsInTitle(Player player)
        {
            Console.Title = $"Life: {player.Life} of {player.MaxLife} ||  XP: {player.XP} || Level: {player.Level} || Inventory Count: {player.Inventory.ShowNumberOfItems()} || Quest Items: {player.QuestItemsList.Count}";
        }

    }
}
